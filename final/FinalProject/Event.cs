
class Event{
    protected List<(string startText, string endText, int type, int number, int money)> _Eventtext;
    protected (string startText, string endText, int type, int number, int money) _ChosenEvent;
    
    public Event(){
         _Eventtext = new List<(string, string, int, int, int)>
        {
            // these events were generated by ChatGPT, the code around them was not.
            // Trap Rooms
            ("You step into a dimly lit corridor. The air is thick with dust, and the floor tiles look suspiciously uneven. On the other side, however, you see a few coins.\n1. Step carefully forward.\n2. Try to jump over the tiles.\n3. Turn back the way you came.", 
            "(1) You manage to avoid the worst of the trap, but a dart still grazes your arm.\n(2) You leap forward, triggering a pressure plate mid-air! A volley of darts fire, several hitting you!\n(3) You wisely avoid the trap altogether, but miss out on any potential rewards.", 1, 1, 0),
            
            ("A vast chamber opens before you, its floor covered in strange, glowing runes.\n1. Step forward cautiously.\n2. Throw a rock onto the runes.\n3. Look for another way around.", 
            "(1) The moment you step forward, the runes flare, fire engulfs you and you feel the heat scorch your skin.\n(2) The rock triggers the trap, and a burst of magical energy scorches the air where you would have stood.\n(3) You find a hidden side passage, but this one is filled with a foul odor...", 1, 2, 0),
            
            ("A narrow bridge of rotting wood stretches over a dark chasm. The air is eerily still.\n1. Walk carefully across.\n2. Sprint as fast as possible.\n3. Search for another way around.", 
            "(1) The bridge creaks under your weight, but you make it across safely.\n(2) Halfway across, the bridge snaps! You leap forward, barely catching the ledge on the other side. You get a little scraped up though...\n(3) After some searching, you find a hidden rope bridge, much sturdier than the first. Why even have the first one? you wonder.", 1, 3, 0),
            
            ("The walls of this hallway are lined with ancient suits of armor, their visors dark and empty.\n1. Walk through cautiously.\n2. Knock on one of the suits of armor.\n3. Search the walls for hidden triggers.", 
            "(1) As you pass by, the armor suddenly animates! Caught off guard, you're cut by a sword!\n(2) The suit of armor collapses harmlessly, but the noise alerts something deeper in the dungeon...\n(3) You find a hidden lever that disarms the trap before it can activate.", 1, 4, 0),
            
            // Treasure Rooms
            ("A small alcove gleams with gold coins scattered across the floor, a lone chest sitting in the corner.", 
            "Inside the chest, you find a handful of precious gems and a curious, rune-etched key.", 2, 5, 50),
            
            ("A fountain in the center of the room bubbles with a shimmering, golden liquid.", 
            "You take a sip and feel revitalized! The magical waters restore some of your strength.", 2, 6, 0),
            
            ("An ornately decorated room greets you, lined with shelves of dusty tomes and enchanted trinkets.", 
            "Among the relics, you find an ancient grimoire, its pages glowing faintly with forgotten power. The knowledge of how to cast the spell firebolt is now yours!", 2, 7, 25),
            
            ("A stone pedestal stands at the center, atop which rests a brilliant, gem-encrusted dagger.", 
            "As you lift the dagger, the air around you hums with energy. This weapon is no ordinary blade!", 2, 8, 0),
            
            // Monster Rooms
            ("The flickering torchlight reveals a pair of glowing red eyes in the darkness. A goblin leaps at you with a wicked dagger!", 
            "After a fierce struggle, you emerge victorious.", 3, 9, 0),
            
            ("The sound of rattling bones echoes through the chamber. A skeletal warrior rises from the ground, brandishing a rusted sword.", 
            "You strike it down, shattering it to dust.", 3, 10, 0),
            
            ("A low growl reverberates through the air as you step into the cavernous room. A hulking troll lumbers toward you.", 
            "After a brutal battle, it collapses, leaving behind a small pouch of gold.", 3, 11, 0),
            
            ("A sickly green mist clings to the floor, the stench of decay thick in the air. A swarm of venomous rats rushes at you!", 
            "You fight them off, but not without a few painful bites.", 3, 12, 0),
            
            // Shop Rooms
            ("A lantern-lit stall is set up in the middle of the chamber, a hooded figure tending to an array of strange wares.", 
            "\"Ah, a traveler! Care to trade?\" the merchant asks, displaying an assortment of potions and trinkets.", 4, 13, 0),
            
            ("A burly dwarf stands behind a sturdy wooden counter, sharpening a gleaming longsword.", 
            "\"Need a weapon? I have the finest steel in the dungeon!\" he boasts.", 4, 14, 0),
            
            ("A small goblin with oversized glasses peers up at you from behind a stack of scrolls.", 
            "\"Magic scrolls, rare and powerful! You won’t find these anywhere else!\" he hisses.", 4, 15, 0),
            
            ("A grizzled old man sits in a corner, surrounded by an assortment of herbs and bubbling cauldrons.", 
            "\"Care for a brew? My potions are strong enough to wake the dead... or put them back down!\" he chuckles.", 4, 16, 0),
            
            // Boss Rooms
            ("The air grows thick with an oppressive energy. A massive stone door looms ahead, ancient carvings warning of danger. With a heavy groan, the door swings open, revealing a monstrous minotaur guarding a hoard of treasure.", 
            "With one final blow, the minotaur collapses, leaving the treasure unguarded.", 5, 17, 0),
            
            ("The chamber is vast and empty, save for a single, armored figure seated upon a throne of bones. The Death Knight rises, drawing a cursed blade. The battle begins.", 
            "The Death Knight lets out a final, haunting wail before crumbling to dust.", 5, 18, 0),
            
            ("A deafening roar shakes the cavern as you enter, flames licking the walls. A dragon stirs from its slumber, its golden eyes locking onto you with predatory intent.", 
            "The dragon lets out a final, shuddering breath before falling still.", 5, 19, 0),
            
            ("Dark chains rattle as you step into the room, and a deep chuckle echoes from the shadows. The Demon Lord himself steps forward, his crimson eyes gleaming. \"You are bold to come here, mortal.\"", 
            "With an agonized cry, the Demon Lord vanishes into the void, leaving behind only his smoldering throne.", 5, 20, 0),
            };
        InitializeEvent();
    }
    protected void InitializeEvent(){
        SelectEvent();
    }
    protected virtual void SelectEvent(){
        System.Console.WriteLine("hello");
        Random rand = new Random();
        _ChosenEvent=_Eventtext.ElementAt(rand.Next(_Eventtext.Count-4));
    }
    public string GetBeginningText(){
        return _ChosenEvent.startText;
    }
    public string GetEndText(){
        return _ChosenEvent.endText;
    }
    public int GetEventType(){
        return _ChosenEvent.type;
    }
    public int GetNumber(){
        return _ChosenEvent.number;
    }
    public int GetMoneyModifier(){
        return _ChosenEvent.money;
    }
    
}