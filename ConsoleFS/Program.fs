﻿open Demo1

[<EntryPoint>]
let main argv =
    Demo1.run ()
    0 

(*

Funksjonell programmering
 - Definisjon - https://en.wikipedia.org/wiki/Functional_programming
 - Parallellisering

Fire paradigmer: 
 - ustrukturert programmering
 - strukturert programmering
    - objektorientert programmering
    - funksjonell programmering

"Uncle Bob", Robert Martin: Clean Architecture:

Each of the paradigms removes capabilities from the programmer. None of them adds new capabilities. 
Each imposes some kind of extra discipline that is negative in its intent. The paradigms tell us 
what not to do, more than they tell us what to do.

Another way to look at this issue is to recognize that each paradigm takes something away from us. 
The three paradigms together remove goto statements, function pointers, and assignment. Is there 
anything left to take away? Probably not. Thus these three paradigms are likely to be the only three 
we will see—at least the only three that are negative. Further evidence that there are no more such 
paradigms is that they were all discovered within the ten years between 1958 and 1968. In the many 
decades that have followed, no new paradigms have been added


Terjes perspektiv: 
 - Kan du unngå tilstand, så gjør det => funksjonell programmering
 - Ellers, kapsle inn tilstand => objektorientert programmering

    https://fsharpforfunandprofit.com/fourfromforty/
    https://github.com/GetAcademy/IntroToFunctionalProgrammingInCS
    https://github.com/GetAcademy/IntroFunctionalJS
    https://mostly-adequate.gitbook.io/mostly-adequate-guide/
*) 
