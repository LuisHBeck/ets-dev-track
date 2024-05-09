package com.beck.springkeycloakserver.service;

import com.beck.springkeycloakserver.dto.KeycloakLoginResponse;
import com.beck.springkeycloakserver.dto.UserLoginRequestDto;
import com.google.gson.Gson;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Service;

import java.io.IOException;
import java.net.URI;
import java.net.URISyntaxException;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.HashMap;
import java.util.Map;

@Service
public class AuthService {

    @Value("${auth-server.keycloak.login-url}")
    private String loginUrl;

    @Value("${auth-server.keycloak.user-creation-url}")
    private String userCreationUrl;

    @Value("${auth-server.keycloak.client-id}")
    private String clientId;

    @Value("${auth-server.keycloak.client-secret}")
    private String clientSecret;

    @Value("${auth-server.keycloak.grant-type}")
    private String grantType;

    @Autowired
    private Gson gson;


    public KeycloakLoginResponse login(UserLoginRequestDto userLoginDto) throws URISyntaxException, IOException, InterruptedException {
        Map<String, String> data = new HashMap<>();
        data.put("client_id", clientId);
        data.put("client_secret", clientSecret);
        data.put("grant_type", grantType);
        data.put("username", userLoginDto.email());
        data.put("password", userLoginDto.password());

        HttpRequest.BodyPublisher bodyPublisher = buildFormDataFromMap(data);

        HttpRequest loginRequest = HttpRequest.newBuilder()
                .uri(new URI(loginUrl))
                .header("Content-Type", "application/x-www-form-urlencoded")
                .POST(bodyPublisher)
                .build();

        HttpClient httpClient = HttpClient.newHttpClient();
        HttpResponse<String> httpResponse = httpClient.send(loginRequest, HttpResponse.BodyHandlers.ofString());

        return gson.fromJson(httpResponse.body(), KeycloakLoginResponse.class);
    }

    // Método para criar o corpo da solicitação a partir de um mapa de dados
    private static HttpRequest.BodyPublisher buildFormDataFromMap(Map<String, String> data) {
        String formData = data.entrySet().stream()
                .map(entry -> entry.getKey() + "=" + entry.getValue())
                .reduce((param1, param2) -> param1 + "&" + param2)
                .orElse("");
        return HttpRequest.BodyPublishers.ofString(formData);
    }
}
