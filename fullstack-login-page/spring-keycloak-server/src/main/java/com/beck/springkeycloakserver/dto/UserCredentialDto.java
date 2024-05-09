package com.beck.springkeycloakserver.dto;

public record UserCredentialDto(
        String type,
        String value,
        boolean temporary
) {
    public UserCredentialDto(String password) {
        this(
                "password",
                password,
                false
        );
    }
}
