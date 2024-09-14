#!/bin/bash

echo "Switching to branch master"
git checkout master

echo "Building app ..."
npm run build

echo "Deploying files to server"
scp -r dist/ root@141.144.237.34:/var/www/html
echo "Done!"
