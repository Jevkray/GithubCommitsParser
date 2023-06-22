# GithubCommitsParser
Git Commits Parser on C#

# ENG

For stable operation, you need a Github token.
The access token can be obtained on the GitHub website. Here's how to do it:

1. Log in to your GitHub account.
2. Click on your avatar in the upper right corner of the screen and select "Settings".
3. In the list on the left, select "Developer settings".
4. In the next list on the left, select "Personal access tokens".
5. Click "Generate new token".
6. Specify the token description and select the necessary permissions for this token. If you only want to read data from the repository, then the "repo" permission (repository) is enough for you.
7. Click "Generate token" at the bottom of the page.
8. Your new personal token will be displayed. Copy it now because you won't be able to see it anymore.

Also you need an a nuget package - Octokit
- dotnet add package Octokit

# RU

Для стабильной работы вам необходим Github токен.
Токен доступа можно получить на сайте GitHub. Вот как это сделать:

1. Войдите в свою учетную запись GitHub.
2. Нажмите на свой аватар в верхнем правом углу экрана и выберите "Settings" (Настройки).
3. В списке слева выберите "Developer settings" (Настройки разработчика).
4. В следующем списке слева выберите "Personal access tokens" (Персональные токены доступа).
5. Нажмите "Generate new token" (Сгенерировать новый токен).
6. Укажите описание токена и выберите необходимые разрешения для этого токена. Если вы только хотите читать данные из репозитория, то вам достаточно разрешения "repo" (репозиторий).
7. Нажмите "Generate token" (Сгенерировать токен) внизу страницы.
8. Ваш новый персональный токен будет отображен. Скопируйте его сейчас, потому что вы больше не сможете его увидеть.

Также вам нужен пакет nuget - Octokit
- dotnet add package Octokit
