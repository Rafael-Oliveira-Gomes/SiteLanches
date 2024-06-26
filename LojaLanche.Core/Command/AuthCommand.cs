﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LojaLanche.Core.Dto;
using LojaLanche.Core.Interface.Command;
using LojaLanche.Core.Interface.Service;
using LojaLanche.Data.Model;
using LojaLanche.Data.Model.Auth.User;
using Microsoft.AspNetCore.Authorization;

namespace LojaLanche.Core.Command
{
    public class AuthCommand : IAuthCommand
    {
        private readonly IAuthService _authService;

        public AuthCommand(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<ResponseCommon<bool>> SignUp(SignUpDto signUpDto)
        {
            try
            {
                bool ret = await _authService.SignUp(signUpDto);

                return ResponseCommon<bool>.Sucesso(ret);
            }
            catch (ArgumentException ex)
            {
                return ResponseCommon<bool>.Falha(ex.Message, 400);
            }
            catch (Exception ex)
            {
                return ResponseCommon<bool>.Falha(ex.Message);
            }
        }

        [AllowAnonymous]
        public async Task<ResponseCommon<SsoDto>> SignIn(SignInDto signInDTO)
        {
            try
            {
                SsoDto ssoDTO = await _authService.SignIn(signInDTO);

                return ResponseCommon<SsoDto>.Sucesso(ssoDTO);
            }
            catch (ArgumentException ex)
            {
                return ResponseCommon<SsoDto>.Falha(ex.Message, 400);
            }
            catch (Exception ex)
            {
                return ResponseCommon<SsoDto>.Falha(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<ResponseCommon<bool>> AddUserToAdminRole(int userId)
        {
            try
            {
                await _authService.AddUserToAdminRole(userId);

                return ResponseCommon<bool>.Sucesso(true);
            }
            catch (ArgumentException ex)
            {
                return ResponseCommon<bool>.Falha(ex.Message, 400);
            }
            catch (Exception ex)
            {
                return ResponseCommon<bool>.Falha(ex.Message);
            }
        }

        public async Task<ResponseCommon<UserBase>> GetCurrentUser()
        {
            try
            {
                var currentUser = await _authService.GetCurrentUser();

                return ResponseCommon<UserBase>.Sucesso(currentUser);
            }
            catch (ArgumentException ex)
            {
                return ResponseCommon<UserBase>.Falha(ex.Message, 400);
            }
            catch (Exception ex)
            {
                return ResponseCommon<UserBase>.Falha(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        public async Task<ResponseCommon<List<ApplicationUser>>> ListUsers()
        {
            try
            {
                List<ApplicationUser> list = await _authService.ListUsers();

                return ResponseCommon<List<ApplicationUser>>.Sucesso(list);
            }
            catch (ArgumentException ex)
            {
                return ResponseCommon<List<ApplicationUser>>.Falha(ex.Message, 400);
            }
            catch (Exception ex)
            {
                return ResponseCommon<List<ApplicationUser>>.Falha(ex.Message);
            }
        }

        [Authorize(Roles = "Funcionario")]
        public async Task<ResponseCommon<UserDto>> GetUserDto(int id)
        {
            try
            {
                UserDto userDto = await _authService.GetUserDto(id);

                return ResponseCommon<UserDto>.Sucesso(userDto);
            }
            catch (ArgumentException ex)
            {
                return ResponseCommon<UserDto>.Falha(ex.Message, 400);
            }
            catch (Exception ex)
            {
                return ResponseCommon<UserDto>.Falha(ex.Message);
            }
        }
    }
}
