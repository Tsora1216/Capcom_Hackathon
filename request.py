import requests

url = 'https://capcom-hackathon.azurewebsites.net/api/HttpTrigger1?code=7PxzqVHLVT4gGxb5kyjnqrAxo1T5RaDGZgf4PgQUOvhgAzFu9y3Mqw==&name=Sora'
response = requests.get(url)

print(response)
print(response.text)