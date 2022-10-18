﻿using SW.Services.Stamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Services.IssueJson
{
    public class IssueJson : IssueJsonService
    {
        /// <summary>
        /// Crear una instancia de la clase IssueJson.
        /// </summary>
        /// <param name="url">URL base.</param>
        /// <param name="user">Usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <param name="proxyPort">Puerto Proxy.</param>
        /// <param name="proxy">Proxy.</param>
        public IssueJson(string url, string user, string password, int proxyPort = 0, string proxy = null) : base(url, user, password, proxyPort, proxy)
        {
        }
        /// <summary>
        /// Crear una instancia de la clase IssueJson.
        /// </summary>
        /// <param name="url">URL base.</param>
        /// <param name="token">Token de autenticación.</param>
        /// <param name="proxyPort">Puerto Proxy.</param>
        /// <param name="proxy">Proxy.</param>
        public IssueJson(string url, string token, int proxyPort = 0, string proxy = null) : base(url, token, proxyPort, proxy)
        {
        }
        /// <summary>
        /// Servicio de Emisión Timbrado de un CFDI en formato JSON.
        /// </summary>
        /// <param name="json">String del CFDI en formato JSON.</param>
        /// <returns>Respuesta V1 de timbrado.</returns>
        public async Task<StampResponseV1> TimbrarV1Async(string json)
        {
            return await IssueJsonV1Async(json);
        }
        /// <summary>
        /// Servicio de Emisión Timbrado de un CFDI en formato JSON.
        /// </summary>
        /// <param name="json">String del CFDI en formato JSON.</param>
        /// <returns>Respuesta V2 de timbrado.</returns>
        public async Task<StampResponseV2> TimbrarV2Async(string json)
        {
            return await IssueJsonV2Async(json);
        }
        /// <summary>
        /// Servicio de Emisión Timbrado de un CFDI en formato JSON.
        /// </summary>
        /// <param name="json">String del CFDI en formato JSON.</param>
        /// <returns>Respuesta V3 de timbrado.</returns>
        public async Task<StampResponseV3> TimbrarV3Async(string json)
        {
            return await IssueJsonV3Async(json);
        }
        /// <summary>
        /// Servicio de Emisión Timbrado de un CFDI en formato JSON.
        /// </summary>
        /// <param name="json">String del CFDI en formato JSON.</param>
        /// <returns>Respuesta V4 de timbrado.</returns>
        public async Task<StampResponseV4> TimbrarV4Async(string json)
        {
            return await IssueJsonV4Async(json);
        }
    }
}
