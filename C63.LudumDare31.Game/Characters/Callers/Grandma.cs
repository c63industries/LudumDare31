using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Grandma : Base
    {
        public static Grandma grandmaHappiness;

        public Grandma()
            : base()
        {
            grandmaHappiness = this;

            this.Dialog.Add
                (
                    "Thank you for calling the North Pole. How may I help you?",
                    "HELLO?! Is this my little Nicky Wicky?",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "Ma'am, I believe you have the wrong number.",
                                "This is my son's number! Who the hell are you?!",
                                () =>
                                {
                                    this.Dialog.Add
                                        (
                                            "Oh my gosh! Ma'am, I'm so sorry.",
                                            "You're darn right you're sorry! You smurfy men always have an uppity attitude. Keeps my little Nicky from calling me.",
                                            () =>
                                            {
                                                this.Dialog.Add
                                                (
                                                    "Ma'am, I'm sure he'll find time to call you soon.",
                                                    "Between you folks and his catnip smoking wife that I've never met, he never has time for me! I demand to speak to him right now!"
                                                );
                                                this.Dialog.Add
                                                    (
                                                        "Maybe if you didn't sound like you ate two packs a day, he'd want to talk to you?",
                                                        "I WANT TO SPEAK TO HIM RIGHT NOW!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'll patch you through now, ma'am. I'm sorry for any inconvenience.",
                                                        "'Bout time, you short idiot. You're a slacker just like the rest of you elvie types."
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Oh, like mother, like son. You're both idiots.",
                                            "WHAT DID YOU JUST SAY TO ME?!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Oh my god. Ma'am, I'm done talking to an IDIOT like you.",
                                                        "Good, because now that you're going to patch me through to my son, we'll be having a discussion about you.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Look, ma'am, I'm just going to patch you through now.",
                                                        "It's about time! You're really starting to get on my nerves, smurfy boy!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm sorry, ma'am. I didn't mean to act like that. The elves have been stressing me out.",
                                                        "Whatever. Just put my son on the phone!"
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "I apologize, ma'am.",
                                            "What the hell is my son paying you for?!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "He's paying me to screen calls right now.",
                                                        "That makes sense, what with that creepy wife of his that only calls to meow at him."
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "He's paying me to answer his business calls. Not his personal calls.",
                                                        "Listen here, Dobby! You patch me through right now!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "You're right, ma'am. Here, I'll patch you through now.",
                                                        "About time, house elf!"
                                                    );
                                            }
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Ma'am, are you talking about Mr. Claws?",
                                "Yes, my son! Are you one of those gnomes that he hires?",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "No, ma'am. I'm a snowman, not an elf.",
                                            "Oh, good. I can't stand those money-grubbing little dwarves. May I talk to my son?",
                                            ()=>
                                                {
                                                    this.Dialog.Add
                                                        (
                                                            "Okay, ma'am. Now that I know you're not one of them, I can patch you straight through!",
                                                            "Well, you have a nice day then, sir, and try to get my son to call me more often!"
                                                        );
                                                    this.Dialog.Add
                                                        (
                                                            "I'm not so sure that's politically correct to say that, ma'am.",
                                                            "Your job isn't to be politically correct! It's to patch me through to my son.",
                                                            ()=>
                                                                this.Emotions.Happiness--
                                                        );
                                                    this.Dialog.Add
                                                        (
                                                            "Me either, ma'am. They're already paid too much, in my opinion.",
                                                            "I'll be sure to tell my son that you need a raise when he cuts their wage!"
                                                        );
                                                }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Does it matter, ma'am?",
                                            "Oh, no. You just have that squeaky sound them little fellers do.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Ma'am. I'm just going to stop right there and patch you through.",
                                                        "Well, fine! Have no manners and just cut off our conversation. See if I care!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "No, ma'am! I'm not one of those filthy elves!",
                                                        "Oh, well good! The last thing I want to do before talking to my son, is talk to an elf."
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Fair enough. I'll patch you through.",
                                                        "Good. I'm starting to get bored with talking to you.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Yes, ma'am, with a pointy little green hat and everything.",
                                            "Oh, let me tell you. You are SO lucky to be in my son's employment. I hear he treats your kind really well.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Yes, because I'm so lucky to get paid so little to patch people like you through.",
                                                        "Oh, just wait until he hears about that comment!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Oh, it's great to have a job with him! You need to let him know that when I patch you through.",
                                                        "I'll definitely do that, sweetheart! You keep up the good job!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Speaking of jobs, I guess I had better patch you through, ma'am.",
                                                        "Good idea. You have a nice day, honey!"
                                                    );
                                            }
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Ah, you must be the delightful Mama Claws that I've heard so much about!",
                                "Why, aren't you a flatterer! You're so much better than that last snowhead he had!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Ma'am, I think you're referring to me, because I'm the only snowman he's employed.",
                                            "Don't you lie to me! I know what my son does!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "I'm sorry, ma'am. It was just a little joke.",
                                                        "Well, it's not funny! Now patch me through to my son!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "You just called us a week ago, ma'am.",
                                                        "I'm calling him now because I haven't talked to him in six months! I want to talk to him NOW!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm sorry. I won't do that again. I'll patch you through.",
                                                        "I'll forgive you this time, but only because I'm in a hurry to talk to him."
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Ma'am, that's actually very insensitive.",
                                            "I know you guys call each other that, so why can't I say it?",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "It's acceptable for us. Not for you.",
                                                        "Just like it's acceptable for me to tell him to fire your cold white butt?",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Wow, ma'am, you are so right. I'm going to patch you through while I think about what I've said.",
                                                        "And don't forget to tell the rest of your kind that, too!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Whatever you say, ma'am. Your son is the boss.",
                                                        "You're darn right he is. Now patch me through!"
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Well, I hope to be around longer than he was.",
                                            "As long as you don't act like those greedy little smurfs, you'll be fine!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Well, if asking for money for decent office supplies is greedy, then I'm so fired.",
                                                        "You're damn right you will be after he hears this!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "No, ma'am. In fact I asked for a pay decrease.",
                                                        "Well, I'll make sure he knows about how much you sacrifice for the business."
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm not even going to respond to that. I'm just going to patch you through.",
                                                        "Like you should have done a long time ago?"
                                                    );
                                            }
                                        );
                                }
                            );
                    }
                );
        }

        void Disconnected(bool hold)
        {
            if (hold)
            {
                return;
            }

            Game.Boss.Emotions.Happiness--;
        }

        void Transferred()
        {
            Game.Boss.Emotions.Happiness++;
        }
    }
}