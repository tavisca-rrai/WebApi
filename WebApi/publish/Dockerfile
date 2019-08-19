# Use an official Python runtime as a parent image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2


# Set the working directory to /app
WORKDIR /host

# Copy the current directory contents into the container at /app
COPY . /host

# Make port 80 available to the world outside this container
EXPOSE 80

# Run app.py when the container launches
CMD ["dotnet", "WebApi.dll"]