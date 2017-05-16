echo CopyFile.bat
echo Begin Copy Files
if %1==Debug (xcopy /e /r /y %2src\RubyLib %2src\bin\Debug\RubyLib\ 
xcopy /e /r /y %2src\Yaml\config.rb %2src\bin\Debug\YLab.YAML\ 
xcopy /e /r /y %2src\Config\Config.yaml %2src\bin\Debug\)
if %1==Release (xcopy /e /r /y %2src\RubyLib %2src\bin\Release\RubyLib\ 
xcopy /e /r /y %2src\Yaml\config.rb %2src\bin\Release\YLab.YAML\ 
xcopy /e /r /y %2src\Config\Config.yaml %2src\bin\Release\)
echo End Copy Files
