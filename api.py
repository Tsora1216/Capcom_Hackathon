import requests

url = "https://capcom-hackathon.azurewebsites.net/api/HttpTrigger1?code=7PxzqVHLVT4gGxb5kyjnqrAxo1T5RaDGZgf4PgQUOvhgAzFu9y3Mqw==&name=Sora"

r = requests.get(url)
print(r)