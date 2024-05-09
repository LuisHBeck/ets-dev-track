package com.beck.springkeycloakserver.dto;

public record KeycloakUserCreationRequestDto(
        String firstName,
        String email,
        boolean enabled,
        UserCredentialDto[] credentials,
        String username
) {
    public KeycloakUserCreationRequestDto(UserCreationRequestDto userDto, UserCredentialDto[] userCredentials) {
        this(
                userDto.name(),
                userDto.email(),
                true,
                userCredentials,
                userDto.email()
        );
    }
}
