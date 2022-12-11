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
    stage('Test') {  
      steps {  
        bat 'dotnet test %WORKSPACE%\\Tests\\Tests.csproj --logger "junit"'
        junit allowEmptyResults: true, testResults: '**\\TestResults\\**.xml'
      }  
    }
    stage('Release'){
      steps {
	      bat 'dotnet build %WORKSPACE%\\CleanArchitecture.sln /p:PublishProfile=" %WORKSPACE%\\DemoWeb\\Properties\\PublishProfiles\\JenkinsProfile.pubxml" /p:Platform="Any CPU" /p:DeployOnBuild=true /m'
      }
    }
    stage('Workspace clean'){
      steps{
        script{
          if(CLEAN_WORKSPACE == "true"){
            deleteDir()
          }
        }
      }
    } 
    stage('Testing frontend'){
      steps{
        script{
          if(TESTING_FRONTEND == "true"){
            echo "TESTING_FRONTEND: ${TESTING_FRONTEND}"
          }
        }
      }
    }
  } 
}