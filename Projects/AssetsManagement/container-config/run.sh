#!/bin/bash
usermod -u $(ls -ldn /var/www/assets-management/ | awk '{print $3}') www-data
groupmod -g $(ls -ldn /var/www/assets-management/ | awk '{print $3}') www-data

service apache2 restart

/bin/sh -c bash

# Important: This keeps the docker instance alive
exec supervisord -n
