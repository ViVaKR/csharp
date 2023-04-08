# op : -eq, -ne, -lt, -le, -gt, -ge
echo "Start Web Server : 1"
echo "Infix To Postfix : 2"
echo "Regular Express : 3"
echo "Convert To Base64 : 4"
echo "MySql Database : 5"
echo
read -p " : " SERVICE
echo

echo "Running... $SERVICE"
echo
echo
case "$SERVICE" in
    '1') dotnet run --project Demo-WebServer;;
    '2') dotnet run --project Demo-InfixPostfix;;
    '3') dotnet run --project Demo-RegEx;;
    '4') dotnet run --project Demo-ToBase64;;
    '5') dotnet run --project Demo-MySql;;
    *) echo "Never heard of ${SERVICE}, sorry"
       exit 1
       ;;
esac
echo
echo
echo "Complete..."
