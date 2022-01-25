:: ====================================================================================================
:: Step 7b: Run the installer in quiet mode (without client execution)
:: ====================================================================================================
:: 
:: Install the MSI and look into the "install-quiet.log" file.
:: 
:: Search for the "Action Start [timestamp]: DummyValidation." message. It is present only once, in the
:: server execution, and it is executed. The expected message is written in the log file.
:: 
:: Note: The same bahavior is found when the installer is run in passive mode: the client execution is
::       skipped and the custom action is run only on server.
:: 
:: END

msiexec /i FirstSequenceCustomAction.msi /l*vx install-quiet.log /quiet

:: Same as:
:: msiexec /i FirstSequenceCustomAction.msi /l*vx install-quiet.log /qn
:: 
:: "/quiet" is equivalent to "/qn"