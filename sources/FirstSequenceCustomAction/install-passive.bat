msiexec /i FirstSequenceCustomAction.msi /l*vx install-passive.log /passive

:: Same as:
:: msiexec /i FirstSequenceCustomAction.msi /l*vx install-passive.log /qb! REBOOTPROMPT=S
:: 
:: "/passive" is equivalent to "/qb! REBOOTPROMPT=S"