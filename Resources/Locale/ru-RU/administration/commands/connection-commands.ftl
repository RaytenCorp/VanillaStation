cmd-grant_connect_bypass-desc = Временно разрешить пользователю игнорировать обычные проверки подключения.
cmd-grant_connect_bypass-help =
    Usage: grant_connect_bypass <user> [duration minutes]
    Временно предоставляет пользователю возможность игнорировать обычные ограничения на подключения.
    Игнорирование применяется только к этому игровому серверу и истечет через (по умолчанию) 1 час.
    Они смогут присоединиться, независимо от белого списка, панического бункера или предела игроков.
cmd-grant_connect_bypass-arg-user = <пользователь>
cmd-grant_connect_bypass-arg-duration = [длительность в минутах]
cmd-grant_connect_bypass-invalid-args = Ожидалось 1 или 2 аргумента
cmd-grant_connect_bypass-unknown-user = Невозможно найти пользователя '{ $user }'
cmd-grant_connect_bypass-invalid-duration = Неверная длительность '{ $duration }'
cmd-grant_connect_bypass-success = Успешно добавлено игнорирование для пользователя '{ $user }'
