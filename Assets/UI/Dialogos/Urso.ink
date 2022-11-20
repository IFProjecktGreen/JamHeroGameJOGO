INCLUDE global.ink
#Urso

{urso == "false": -> main | -> pegou}

=== main ===
(Você pegou o urso)
~ urso = "true"
    -> DONE
    
=== pegou ===
(Você já pegou o urso)
    -> DONE
    
-> END