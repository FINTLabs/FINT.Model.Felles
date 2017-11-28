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
      steps {
        sh 'dotnet restore -p:Version=2.2.10'
        sh 'dotnet build -c Release -p:Version=2.2.10'
        sh 'dotnet pack -c Release -p:Version=2.2.10'
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
        sh "dotnet nuget push FINT.Model.Felles/bin/Release/FINT.Model.Felles.*.nupk -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}