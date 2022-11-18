INCLUDE global.ink

#???

{CamaCena6 == "true": -> main}

=== main ===
Olha só o que temos aqui, o homem que matou sua própria mulher
Deve ser realmente um orgulho para a sua família
HAHAHAHA
Mas vai muito além disso, isso tudo não se trata só da morte da sua esposa
Você sabe muito bem disso
Você nunca foi um bom marido, quem dirá um bom pai
O trabalho sempre foi prioridade para você, ficava acima até mesmo da sua família
Como você se sente com tudo isso?
    *[...]
        Era de se esperar HAHAHAHA
        Vocês humanos nunca cansam de me fazer rir
    *[Não foi culpa minha]
        Eu posso não ser nenhum tipo de detetive, mas eu acho que quem estava bêbado e dirigindo era você!
        Fazer o que se os humanos são os seres mais orgulhosos e arrogantes que existem
        Piores até que nós demônios
        
-Mas e se...
-E se você tivesse uma oportunidade para poder reverter tudo isso?
-De você mudar o seu passado e trazer sua esposa de volta
-Você estaria disposto a aceitar?
    *[Sim!!]
        Uma pena que não tem HAHAHAHAHA
    *[Isso é possível??]

-Não para você, um simples humano
-Mas eu consigo te levar de volta para o passado
-Porém, isso tem um preço
    *[Qual?]
        Você ama mesmo a sua mulher?
        Quer dizer... Amava 
        HAHAHAHAHA
        Digamos que o preço é um pouco da sua vida
    *[Não importa o preço]
        Esse é o espírito da coisa
-Tudo bem então, é só apertar a minha mão e tudo está feito
    *[Apertar]
        Boa decisão garotinho
        Resumindo tudo, você só tem 1 oportunidade para reverter esse ocorrido, não desperdice, ou desperdice, você que sabe
        Já que eu só consigo te levar para o passado duas vezes antes de você...
        Enfim, boa sorte!
        ~DemonioContrato = "true"
            -> DONE
    *[Não apertar]
        Olha só, parece que você realmente não se arrepende disso
        Bom, vou te dar mais uma chance para apertar
        Se recusar vai ter que repetir esse diálogo gigante novamente
        Você que sabe HAHAHAHAHA
            **[Apertar]
                Boa decisão garotinho
                Resumindo tudo, você só tem uma chance de reverter esse ocorrido
                Já que eu só consigo te levar para o passado duas vezes antes de você...
                Enfim, boa sorte!  
                ~DemonioContrato = "true"
                    -> DONE
            **[Não apertar]
                ~Final1 = "true"
                Cagão...
                    ->DONE
    
-> END
    
    
    
    
    
    
    