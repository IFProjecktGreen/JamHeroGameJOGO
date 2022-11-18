INCLUDE global.ink

#Chefe

{SemFesta == "true": -> Chefe3}
{chefe == "true": -> Chefe2 | -> Chefe}

=== Chefe ===
Olha só quem chegou
O novo gerente da empresa!!!
    *[Desculpa chefe, mas eu não vou poder ficar]
        Mas você é o convidado especial
        Você sabe o que vai acontecer se você não ficar né
        Tem certeza?
            **[Sim, me desculpa, mas é o aniversário da minha filha e eu não posso deixar para lá]
                Tudo bem, você que sabe
                ~SemFesta = "true"
                    ->DONE
            **[...Certo, é só eu não beber de mais]
                Tem que beber muito!!!!
                Vamos comemorar muito esse dia e ano especial para todos nós
                Podem abrir suas cervejas e começar a rodada!!
                ~chefe = "true"
                    ->DONE
    *[Cheguei para começar a festa!!!!]
        Esse é o espírito!!
        Vamos comemorar muito esse dia e ano especial para todos nós
        Podem abrir suas cervejas e começar a rodada!!
        ~chefe = "true"
            ->DONE

=== Chefe2 ===
Ai meu Deus, está tudo girando
Acho melhor a gente parar
    ->DONE

=== Chefe3 ===
Você fez a sua decisão, espero que não se arrependa
    ->DONE


-> END