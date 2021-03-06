# SwaggerUiBugDemo

This is a small demonstration of a bug in the swagger-ui.
If you return any text file from your API and it contains bytes which aren't valid UTF-16 Characters, then the swagger-ui will return a file that is different from the file that the endpoint itself returns.
This is confusing, while debugging the endpoint.

## How this repo was created

```bash
dotnet new webapi
dotnet new gitignore

```
Then I included a minimal controller, demonstrating the issue and deleted unneccessary files.

## How to run this

Just use `dotnet run` inside of the cloned folder.
Navigate your browser to https://localhost:7289/swagger/index.html

## How to run this with docker

```
docker build -t swagger-ui-bug-demo .
docker run --rm -p 7289:80 swagger-ui-bug-demo
```
Navigate your browser to http://localhost:7289/swagger/index.html