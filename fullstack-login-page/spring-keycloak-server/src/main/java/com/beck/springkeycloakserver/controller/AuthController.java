package com.beck.springkeycloakserver.controller;

import com.beck.springkeycloakserver.dto.KeycloakLoginResponse;
import com.beck.springkeycloakserver.dto.UserCreationRequestDto;
import com.beck.springkeycloakserver.dto.UserLoginRequestDto;
import com.beck.springkeycloakserver.service.AuthService;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.io.IOException;
import java.net.URISyntaxException;

@RestController
@RequestMapping("/auth")
public class AuthController {

    @Autowired
    private AuthService authService;

    @GetMapping()
    public ResponseEntity<String> test() {
        return ResponseEntity.ok("its working");
    }

    @PostMapping("/login")
    public ResponseEntity<KeycloakLoginResponse> login(@RequestBody @Valid UserLoginRequestDto userLoginRequestDto)
            throws URISyntaxException, IOException, InterruptedException
    {
        KeycloakLoginResponse keycloakLoginResponse = authService.login(userLoginRequestDto);
        return ResponseEntity.ok(keycloakLoginResponse);
    }

    @PostMapping("/signup")
    public ResponseEntity signup(@RequestBody @Valid UserCreationRequestDto userCreationRequestDto)
            throws URISyntaxException, IOException, InterruptedException
    {
        authService.createUser(userCreationRequestDto);
        return ResponseEntity.noContent().build();
    }
}
