const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:40915';

const PROXY_CONFIG = [
  {
    context: [
      "/api/auth",
    ],
    target: target, // Use the appropriate target URL for authentication
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  },
  {
    context: [
      "/api/leave",
    ],
    target: target, // Use the appropriate target URL for leave-related requests
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
]

module.exports = PROXY_CONFIG;
