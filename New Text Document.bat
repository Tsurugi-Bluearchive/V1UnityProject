@echo off
setlocal enabledelayedexpansion

for /r %%f in (*Henry*) do (
    set "fullpath=%%f"
    set "filename=%%~nxf"
    set "folder=%%~dpf"
    set "newname=!filename:Henry=V1!"
    
    if not "!filename!"=="!newname!" (
        pushd "%%~dpf"
        ren "%%~nxf" "!newname!"
        popd
        echo Renamed: %%f -> !newname!
    )
)

echo.
echo All matching files have been renamed.
pause