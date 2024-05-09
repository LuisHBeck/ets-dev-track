package com.beck.springkeycloakserver.dto;

import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;

public record UserLoginRequestDto(
        @NotNull
        String email,
        @NotBlank
        String password
) {
}
