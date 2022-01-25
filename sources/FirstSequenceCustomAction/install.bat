:: ====================================================================================================
:: Step 7a: Run the installer  (client and server executions)
:: ====================================================================================================
:: 
:: Install the MSI normally and look into the "install.log" file.
:: Search for the "Action Start [timestamp]: DummyValidation." message. It must be present twice:
:: 
::      - First, executed by the client application (it should have a "(c)" text at the beginning of
::        the line). Here it is fully executed and the messages written from the C# method should be
::		  visible here.
:: 
:: 	    - Second, executed by the server application (it should have a "(s)" text at the beginning of
::        the line). Here it should be a message saying that the execution is skipped.
:: 
:: Note: Run the uninstall.bat to uninstall the product.
::
:: NEXT: install-quiet.bat

msiexec /i FirstSequenceCustomAction.msi /l*vx install.log

:: Same as:
:: msiexec /i FirstSequenceCustomAction.msi /l*vx install.log /qf
:: 
:: The default UI level, if not explicitly specified, is Full UI: "/qf"