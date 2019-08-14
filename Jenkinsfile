pipeline {
    agent any
    parameters {
        string(name: 'GIT_HTTP_PATH', defaultValue: 'https://github.com/tavisca-rrai/WebApi.git', description: 'Value For Git Repo')
        string(name: 'SOLUTION_FILE_PATH', defaultValue: 'WebApi.sln', description: 'Path to the Solution')
        string(name: 'TEST_PROJECT_PATH', defaultValue: 'webApiTest/webApiTest.csproj', description: 'Path to Tests project')
        choice(name: "Environment", choices: ["build","test"],description : 'Select Environment to run')
    }
    stages {
        stage('build') {
            when {
                expression {
                  params.Environment == 'build';
                }
            }
            steps {
                sh '''
                dotnet restore ${SOLUTION_FILE_PATH} --source https://api.nuget.org/v3/index/json
                dotnet build ${SOLUTION_FILE_PATH} -p:Configuration=release -v:n
                '''
            }
        }
        stage('test') {
            when {
                expression {
                  params.Environment == 'test';
                }
            }
            steps {
               sh'''
               dotnet test ${TEST_PROJECT_PATH}
               '''               
            }
        }
    }
}