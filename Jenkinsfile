pipeline {
  agent any
  
  triggers {
    cron('H/5 * * * *')
  }
  
  environment {
    ECR_REPOSITORY = '328440967566.dkr.ecr.us-east-1.amazonaws.com' // Replace with your ECR repository URI
    IMAGE_TAG = "build-${env.BUILD_NUMBER}" // Use the build number as the image tag
  }
  
  stages {
    stage('Authenticate with ECR') {
      steps {
        script {
          withCredentials([awsSecretKey(credentialsId: 'aws-ecr-credentials', variable: 'AWS_SECRET_ACCESS_KEY'), 
                           awsAccessKey(credentialsId: 'aws-ecr-credentials', variable: 'AWS_ACCESS_KEY_ID')]) {
            sh "aws ecr get-login-password --region us-east-1 | docker login --username AWS --password-stdin $ECR_REPOSITORY"
          }
        }
      }
    }
    
    stage('Build and Push Image') {
      steps {
        sh "docker build -t $ECR_REPOSITORY/apiApp:${IMAGE_TAG} ./salemVentures/salemVentures/Dockerfile "
        sh "docker push $ECR_REPOSITORY/apiApp:${IMAGE_TAG}"
      }
    }
  }
}