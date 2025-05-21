#!/bin/bash

# Получаем информацию о пользователе и системе

USERNAME=$(whoami)
HOSTNAME=$(hostname)
CURRENT_DATE=$(date "+%Y-%m-%d %H:%M:%S")
UPTIME=$(uptime | awk '{print $3, $4, $5, $6}') # Извлекаем время работы системы
KERNEL_INFO=$(uname -sr)
LOGGED_IN_USERS=$(w | awk 'NR>2 {print $1}')  # Получаем список пользователей, исключая заголовки
LOAD_AVERAGE=$(uptime | awk -F 'average:' '{print $2}' | sed 's/ //g') # Получаем среднюю загрузку системы

# Форматируем вывод с помощью printf

printf "----------------------------------------\n"
printf "  Информация о пользователе и системе  \n"
printf "----------------------------------------\n"
printf "Пользователь:  %s\n" "$USERNAME"
printf "Имя хоста:      %s\n" "$HOSTNAME"
printf "Текущая дата:   %s\n" "$CURRENT_DATE"
printf "Время работы:   %s\n" "$UPTIME"
printf "Ядро:           %s\n" "$KERNEL_INFO"
printf "----------------------------------------\n"
printf "Подключенные пользователи:\n"
if [[ -z "$LOGGED_IN_USERS" ]]; then
  printf "  Нет активных пользователей, кроме текущего.\n"
else
  for user in $LOGGED_IN_USERS; do
    printf "  - %s\n" "$user"
  done
fi
printf "----------------------------------------\n"
printf "Средняя загрузка: %s\n" "$LOAD_AVERAGE"
printf "----------------------------------------\n"
