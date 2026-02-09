# Pushing Changes from PC to College account repo and Personal Repo simultaneously using this PowerShell Script batch commands

# If multiple remotes are configured for the same local repo, then from windows credential manager, remove the git entry that is not active.

# PowerShell permissions, if necessary first time only
# Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy RemoteSigned

# For first time configuration only. Run as terminal command within VSCode. You do not need to connect to both repos because git REMOTE would do that for both.
# cd repo folder
# dir -force
# Initialize local PC folder for git commands
# git init 

# Add both remotes for the same local repo. You only need to do this once, then you can use the remote names to push to both repos simultaneously.
# You can check the remote names and URLs with "git remote -v" command. You can also remove the remotes if you want to change them or stop pushing to one of the repos.


# git remote add personal https://github.com/IbrahimDarGit/CSharpFundamentals
# git remote remove personal https://github.com/IbrahimDarGit/CSharpFundamentals
#

# You can remove one if both are giving errors
# git remote add college  https://github.com/IbrahimAQ235/CSharpFundamentals
# git remote remove college  https://github.com/IbrahimAQ235/CSharpFundamentals
# git remote -v 

git status

git pull college main --allow-unrelated-histories

# Stop on any error
$ErrorActionPreference = "Stop"

# Create ISO date-time (safe for git messages)
$timestamp = Get-Date -Format "yyyyMMMddTHHmmss"

Write-Host "Adding changes..."
git add .

Write-Host "Committing..."
git commit -m "IbrahimDar Auto update Push on $timestamp"

Write-Host "Pushing to PERSONAL repo..."
git push personal main

Write-Host "Pushing to COLLEGE repo..."
git push college main

Write-Host "Done Successfully!"