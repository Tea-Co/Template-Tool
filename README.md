**Template-Tool Project Documentation**
=====================================

**Overview**
------------

The Template-Tool project is a web application built using ASP.NET Core 9.0.

**Project Structure**
--------------------

The project consists of the following files and directories:

* `README.md`: This file contains a brief description of the project.
* `Dockerfile`: This file defines the Docker image for the project.
* `Template-Tool.csproj`: This file is the project file for the ASP.NET Core web application.
* `LICENSE`: This file contains the MIT License for the project.
* `Properties/launchSettings.json`: This file contains the launch settings for the project.
* `Program.cs`: This file is the entry point for the web application.
* `docker-compose.yml`: This file defines the Docker Compose configuration for the project.

**Docker Configuration**
-----------------------

The project uses Docker to containerize the application. The `Dockerfile` defines the base image as `mcr.microsoft.com/dotnet/aspnet:9.0` and copies the project files into the container. The `docker-compose.yml` file defines a service named `tool` that builds the Docker image and sets environment variables.

**Web Application**
-----------------

The web application is defined in `Program.cs`. It creates a web application builder and defines two endpoints:

* `/health`: Returns a 200 OK response with the message "Healthy".
* `/execute`: Accepts a JSON payload with a `prompt` property and returns the prompt as a response.

**Template Registration**
----------------------

The project appears to register a template with an agent using the `AGENT_URL` environment variable. The registration payload is defined in `Program.cs` and includes the template name, description, parameters, and endpoint.

**Environment Variables**
-------------------------

The project uses the following environment variables:

* `AGENT_URL`: The URL of the agent to register the template with.

**Network Configuration**
------------------------

The project uses a Docker network named `default-network`. The `docker-compose.yml` file defines the network as external.
