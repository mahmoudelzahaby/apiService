# DevOps Challenge: API Service Deployment



### This project demonstrates the deployment process of an API service using .NET. It involves creating the API service, Dockerizing it, setting up a CI/CD pipeline, creating a Helm chart, and deploying it to Kubernetes.

--------------------------
## Overview
Simple web application that prints the request header, method, and body. Tech stack and language are your choices.
--------------------------
### Steps
- Create the API Service: Develop the API service using .NET framework, implementing the desired functionality and endpoints.

- Dockerize the API Service: Containerize the API service using Docker for consistent and portable deployments.

- Set up CI/CD Pipeline: Configure a CI/CD pipeline to automate the build, test, and deployment process.

- Create Helm Chart: Generate a Helm chart defining the deployment, service, and configurations.

- Deploy to Kubernetes: Deploy the API service to a Kubernetes cluster using the Helm chart.

### Usage
Clone the repository: git clone https://github.com/your/repository.git

Make sure to have prerequisites: .NET framework, Docker, K8s, Helm.

- To run the app using docker build the docker image -->
  ```
  cd salemVentures/salemVentures
  docker build . {appName:Tag}
  docker run -p 8080:80 {appName:Tag}
  ```
- Then You can access it using browser --> http://localhost:8080
- Try the api using tools like (Postman)

  
### Helm Chart
The Helm chart defines the deployment, service, and configuration of the API service in Kubernetes.
Customize the chart templates and values.yaml file as per your requirements.
- To run it using helm chart after deploy it in registery (public, private)
  ```
  helm install {name} /apiApp-helm
  ```
- To run using simple yaml file in kubernetes (EKS)
  ***NOTE*** Don't forget to change the values in the deployment and consider the cluster to change the service type or adding ingress.
  ```
  cd K8S
  kubectl apply -f .
  ```
---

### CI/CD Pipeline
The CI/CD pipeline automates the build and deployment process in kubernetes cluster (EKS) by adding cron job check the commits of the master branch to fire the pipeline if there are any commits.
Customize the pipeline Using jenkinsfile.




-------


## Contributing
Contributions are welcome! Submit pull requests or open issues for any improvements or issues encountered.
