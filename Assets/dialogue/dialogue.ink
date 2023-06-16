So, it's a bit late, isn't it?

Where are you headed?

->choicegroup1
==choicegroup1==
+ [Oh, just to a friend's house, he's throwing a party his 21st] ->Ohjusttoafriendshouse
+ [Trying to get home, it's been a long night] -> Tryingtogethome
+ [Just a short drive down this road and to the right. I just want to get there quickly so can you please hurry up?] ->shortdrive

==Ohjusttoafriendshouse==
you sure you should be out here at night? You know it's very dangerous to be out here, who knows, this could've been your last night if I didn't pick you up

+ [I'm fine, my friend's are waiting and they know where I am] -> Imfine
+ [It's ok, you know I've done this many times before] ->itsok
+ *Stay silent*->staysilent

==Tryingtogethome==
you sure you should be out here at night? You know it's very dangerous to be out here, who knows, this could've been your last night if I didn't pick you up

+ [I'm fine, my friend's are waiting and they know where I am] ->Imfine
+ [It's ok, you know I've done this many times before] ->itsok
+ *Stay silent* ->staysilent

==shortdrive==
YOU: why are you driving so late at night?

DRIVER: I do not need to give you an answer, I'm just here to take you to your destination 
-> Ohjusttoafriendshouse


==Imfine==
I see
->END

==itsok==
Are you sure? You know it's very dangerous being out alone at night. You never know, I might've saved your life tonight

YOU: hahaha, ok....
->END

==staysilent==
->END