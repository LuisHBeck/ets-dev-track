package com.beck.springkeycloakserver.dto;

import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;

public record UserCreationRequestDto(
        @NotBlank @NotNull
        String name,
        @NotBlank @NotNull
        String email,
        @NotBlank @NotNull
        String password
) {
}
