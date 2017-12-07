pipeline {
  agent none
  stages {
    stage('Build') {
      agent {
        docker {
          label 'docker'
          image 'microsoft/dotnet'
        }
      }
      environment {
        VERSION = '2.2.20'
      }
      steps {
        sh 'dotnet clean'
        sh 'dotnet restore -s https://api.bintray.com/nuget/fint/nuget'
        sh 'dotnet build -c Release'
        sh 'dotnet pack -c Release'
        stash includes: '**/Release/*.nupkg', name: 'libs'
      }
    }

    stage('Deploy') {
      agent {
        docker {
          label 'docker'
          image 'microsoft/dotnet'
        }
      }
      environment {
        BINTRAY = credentials('fint-bintray')
      }
      when {
        branch 'master'
      }
      steps {
        unstash 'libs'
        archiveArtifacts '**/*.nupkg'
        sh "dotnet nuget push FINT.Model.Felles/bin/Release/FINT.Model.Felles.*.nupkg -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}