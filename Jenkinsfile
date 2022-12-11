pipeline {  
  agent any  
	environment {  
    ON_SUCCESS_SEND_EMAIL = "true"
    ON_FAILURE_SEND_EMAIL = "true"
	  dotnet = 'C:\\Program Files\\dotnet\\dotnet.exe'  
 	}  

  stages {
stage('Build') {  
  	  steps {  
        bat 'dotnet build %WORKSPACE%\\CleanArchitecture.sln --configuration Release'
      }  
    } 	
  }
}