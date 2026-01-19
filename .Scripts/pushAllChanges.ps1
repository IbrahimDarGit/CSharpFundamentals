# Pushing Changes from PC to College account repo and Personal Repo simultaneously using this PowerShell Script batch commands

# PowerShell permissions, if necessary first time only
# Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy RemoteSigned

# For first time configuration only. Run as terminal command within VSCode. You do not need to connect to both repos because git REMOTE would do that for both.
# cd repo folder
# dir -force
# Initialize local PC folder for git commands
# git init 
# git remote add personal https://github.com/IbrahimDarGit/CSharpFundamentals
# git remote add college  https://github.com/IbrahimAQ235/CSharpFundamentals
# git remote -v 


# Stop on any error
$ErrorActionPreference = "Stop"

git status

git pull

# Create ISO date-time (safe for git messages)
$timestamp = Get-Date -Format "yyyyMMMddTHHmmss"

Write-Host "Adding changes..."
git add .

Write-Host "Committing..."
git commit -m "IbrahimDar Auto update Push on $timestamp"

#Write-Host "Pushing to PERSONAL repo..."
#git push personal main

Write-Host "Pushing to COLLEGE repo..."
git push college main

Write-Host "Done Successfully!"
