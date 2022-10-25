﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SW.Services.Authentication;
using SW.Test.Helpers;

namespace SW.Test.Services.AuthenticationTest
{
    [TestClass]
    public class AuthenticationTest
    {
        #region UT Success
        [TestMethod]
        public async Task Authenticate_Success()
        {
            Authentication auth = new Authentication("https://services.test.sw.com.mx", BuildHelper.User, BuildHelper.Password);
            var response = await auth.GenerateTokenAsync();
            Assert.IsTrue(response.Status.Equals("success"));
            Assert.IsNotNull(response.Data);
            Assert.IsTrue(!String.IsNullOrEmpty(response.Data.Token));
            Assert.IsTrue(response.Data.Expires_in > 0);
        }
        #endregion
        #region UT Error
        [TestMethod]
        public async Task Authenticate_WrongCredentials_Error()
        {
            Authentication auth = new Authentication("https://services.test.sw.com.mx", BuildHelper.User, "12345");
            var response = await auth.GenerateTokenAsync();
            Assert.IsTrue(response.Status.Equals("error"));
            Assert.IsTrue(response.Message.Equals("AU2000 - El usuario y/o contraseña son inválidos, no se puede autenticar el servicio."));
        }
        [TestMethod]
        public async Task Authenticate_InvalidUrl_Error()
        {
            Authentication auth = new Authentication(null, BuildHelper.User, BuildHelper.Password);
            var response = await auth.GenerateTokenAsync();
            Assert.IsTrue(response.Status.Equals("error"));
            Assert.IsNotNull(response.Message);
            Assert.IsNotNull(response.MessageDetail);
        }
        [TestMethod]
        public async Task Authenticate_WrongUrl_Error()
        {
            Authentication auth = new Authentication("https://test.sw.com.mx", BuildHelper.User, BuildHelper.Password);
            var response = await auth.GenerateTokenAsync();
            Assert.IsTrue(response.Status.Equals("error"));
            Assert.IsNotNull(response.Message);
            Assert.IsNotNull(response.MessageDetail);
        }
        #endregion
    }
}
