pipeline{
    agent any
    options {timestamps()}
    
    stages{
        stage ("Print Env variables"){
            steps{
            echo "$BUILD_ID is the build Id"
            echo "$BUILD_DISPLAY_NAME is the build display name" 
            echo "$JOB_NAME is the Job name"
            echo "$WORKSPACE is the workspace"
            echo "$BUILD_URL is the build URL"
            echo "$PWD is the current working directory"
            }
            
            
        }
        stage ("Git Checkout"){
            steps{
                git 'https://github.com/ssurigithub/codeCoverageSample.git'
            }
            
        }
        stage ("Build"){
            steps{
                echo 'Build the project'
            sh 'dotnet build -c Release'
            }
            
        }
        stage ("Install dotnet tool reportgenerator"){
            steps{
                echo 'install reportgenerator'
            
                sh 'dotnet tool install dotnet-reportgenerator-globaltool --tool-path tools'
            }
            
        }
        stage ("run tests"){
            steps{
                echo 'publish the build'
            sh './run-tests.sh'
            }
            
        }

        stage ("cobertura report"){
            steps{
                echo "publish the code coverage report using the cobertura plugin"
                cobertura coberturaReportFile: './calculatorLibrary.Tests/BuildReports/Coverage/coverage.cobertura.xml'
                
            }
        }

        
        
    }
    
}