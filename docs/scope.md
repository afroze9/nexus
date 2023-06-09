# Project Scope
Create a simple microservices based application with the following components:

* [x] Service Discovery (Consul)
    * [x] Basic Setup
    * [x] Setup Scripts
    * [x] ACL Setup
    * [ ] ~~mTLS Setup~~
* [x] Configuration Server **(One or more of)**
    * [x] Consul KV
    * [ ] ~~Vault~~
* [x] Api Gateway (Ocelot)
    * [x] Project Setup
    * [x] Connection with Consul
    * [x] Auth Implementation
    * [x] Add routes for company-api
    * [x] Add routes for project-api
    * [x] Consul Policies
    * [x] Consul Configuration
* [x] Logging/Monitoring **(One of)**
    * [ ] ~~Azure Application Insights~~
    * [x] ELK
        * [x] [Create Docker Compose Files](https://www.elastic.co/guide/en/elasticsearch/reference/current/docker.html)
* [x] Tracing
    * [x] Setup Jaeger using Docker
* [x] Authentication/Authorization **(One of)**
    * [ ] ~~Azure AD~~
    * [ ] ~~Keycloak~~
    * [ ] ~~Identity Server~~
    * [x] Auth0
        * [x] Create an API
        * [x] Create Backend Application
        * [x] Create Frontend Application
        * [x] Documentation
* [x] Health checks dashboard
* [x] Backend Apis (.NET 7)
    * [x] Company API
        * [x] Project Setup
        * [x] Logging
        * [x] [Tracing using OpenTelemetry](https://github.com/open-telemetry/opentelemetry-dotnet/blob/main/src/OpenTelemetry.Instrumentation.AspNetCore/README.md)
        * [x] Auth
        * [x] Controllers
        * [x] Health checks
        * [x] Docker file
        * [x] Unit Tests
        * [ ] ~~Integration Tests~~
        * [x] CI/CD
        * [x] Consul Policies
        * [x] Consul Configuration
    * [x] Project Api
        * [x] Project Setup
        * [x] Logging
        * [x] [Tracing using OpenTelemetry](https://github.com/open-telemetry/opentelemetry-dotnet/blob/main/src/OpenTelemetry.Instrumentation.AspNetCore/README.md)
        * [x] Auth
        * [x] Controllers
        * [x] Health checks
        * [x] Docker file
        * [x] Unit Tests
        * [ ] ~~Integration Tests~~
        * [x] CI/CD
        * [x] Consul Policies
        * [x] Consul Configuration
* [x] Frontend Application
    * [x] SolidJS App
    * [x] Integration with Auth0
    * [x] Tests
    * [x] CI/CD
* [ ] Create Deployment Files for K8s
    * [ ] [ELK](https://phoenixnap.com/kb/elasticsearch-kubernetes)
* [ ] Misc
    * [x] Finalize Project Scope
        * [x] Task Assignment
        * [x] Trainings
            * [x] Docker
        * [x] Development
        * [x] Documentation
        * [x] Component Integration
        * [ ] Presentation / Demo
        * [x] Move ACL for each microservice to its own service directory
        * [ ] 
          ~~[Use certificates generated by Elastic to validate serilog connection](https://www.elastic.co/guide/en/elasticsearch/client/net-api/2.x/working-with-certificates.html)~~
