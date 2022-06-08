# HOW TO RUN

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=P@ssw0rd" \
-p 1450:1450 --name sqlsv \
-d goldfivve/pharmacare-database
