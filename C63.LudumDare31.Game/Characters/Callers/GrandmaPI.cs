using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class GrandmaPI : Base
    {
        public static GrandmaPI piHappiness;

        public GrandmaPI()
            : base()
        {
            piHappiness = this;

            this.Dialog.Add
                (
                "Thank you for calling the North Pole. How can I help you today?",
                "Yeah, I'd like to talk to my little Nicky?",
                () =>
                {
                    this.Dialog.Add
                        (
                            "May I ask who this is?",
                            "How do you not know who I am?! I'm Nicholas's mother!",
                            () =>
                            {
                                this.Dialog.Add
                                    (
                                        "My apologies, ma'am. I'm just making sure that no elves disturb Mr. Claws now.",
                                        "Well, sir, I will have you know that I'm not an elf!",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "I just had to double check. We know that they have some private investigator trying to get dirt on us.",
                                                    "Oh, no! Well, then, patch me through to my son to see what's going on with him and the elves this time.",
                                                    () =>
                                                        this.Emotions.Happiness++
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Really? Because you sound about as dumb as a box of them. A box of elves.",
                                                    "That's it! I need to speak to my son right now!",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                            this.Dialog.Add
                                                (
                                                    "I believe you, ma'am. You don't sound like one of those screechy little freaks.",
                                                    "... Well, that's good. May I speak to my son?",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                        }
                                    );
                                this.Dialog.Add
                                    (
                                        "Sorry, ma'am. I'm new to this position, and I didn't know who you were.",
                                        "That's probably because all of his elven workers keep leaving due to the crappy pay!",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "How do you know what their pay is?",
                                                    "That's none of your business. Now let me talk to my son!",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Well, maybe if they actually worked around here, they would make better pay.",
                                                    "I see. Well, if it's not inconvenient, I'd like to speak to my son.",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Yes. They make less than me, and my pay is $2.15 an hour, plus tips.",
                                                    "But... you're a secretary. How do you make tips? Whatever. Just let me talk to Santa."
                                                );
                                        }
                                    );
                                this.Dialog.Add
                                    (
                                        "Sorry, you just sound like a loon. I guess the boss gets that from you.",
                                        "WHAT IS THAT SUPPOSED TO MEAN?!",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "Exactly what it sounds like. You sound like a fruitcake made with too many nuts.",
                                                    "OKAY. I WANT TO TALK TO MY SON RIGHT NOW!",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                            this.Dialog.Add
                                                (
                                                    "See, yelling doesn't make you sound less crazy.",
                                                    "YOU'RE GOING TO REGRET SAYING THAT WHEN I TELL MY SON! AS A SNOWMAN, YOU DON'T KNOW HOW HARD IT IS BEING A GRANDMOTHER!",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Oh, I'm sorry. Are you too stupid to know what a loon is? I can define that for you.",
                                                    "YOU'RE GOING TO BE THE EXAMPLE FOR FIRED IN THE DICTIONARY WHEN I TELL MY SON!",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                        }
                                    );
                            }
                    );
                    this.Dialog.Add
                        (
                            "Ah! This must be the famous Grandma Claws that I've heard so much about.",
                            "Why yes, I am! You must be my son's new secretary.",
                            () =>
                            {
                                this.Dialog.Add
                                    (
                                        "Yes, ma'am. I was just hired a month ago.",
                                        "You must be one of those snowmen, since he hates elves so much.",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "It's not that he hates elves. He just hates how they ask for equal pay.",
                                                    "What?! I mean... I'M GOING TO TELL HIM YOU SAID THAT!",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Oh, he doesn't hate the elves. I'm sure it's just a misunderstanding between them.",
                                                    "Ah, I see. Well, it was nice talking to you, but I'd like to speak with him now."
                                                );
                                            this.Dialog.Add
                                                (
                                                    "I'm indeed a snowman, ma'am. I'll put you through.",
                                                    "I knew it! And you won't even deny that he hates elves! I'm going to be talking about this.",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                        }
                                    );
                                this.Dialog.Add
                                    (
                                        "Yes, ma'am. It's a pleasure talking to you.",
                                        "Well, aren't you such a flatterer! You're obviously not one of the elves?",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "Wow. Ma'am. That is racist as hell. How am I supposed to sound?",
                                                    "Nevermind! It was nothing. Just please, put me through to my son."
                                                );
                                            this.Dialog.Add
                                                (
                                                    "No, ma'am! I'm glad I'm not one of those pointy-ears.",
                                                    "I see. Well, it's a darn good thing we're not, because of the horrible conditions that they deal with! Now, if you could just patch me through."
                                                );
                                        }
                                    );
                                this.Dialog.Add
                                    (
                                        "No, I'm not one of his slaves.",
                                        "That's a lie! I know you're not an elf. I mean, I don't think you are.",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "You're right. The conditions they work in are atrocious. It was bad of me to make that joke.",
                                                    "Yes, it was! Patch me through, but remember to never make that kind of joke again!",
                                                    ()=>
                                                        this.Emotions.Happiness++
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Oh, so just because I'm a snowman, that manes that I'm not forced to work in inhumane conditions?",
                                                    "That's not what I meant. What I meant to say was... just patch me through to my son, please."
                                                );
                                            this.Dialog.Add
                                                (
                                                    "With the wages I get paid? You might as well call it slave labor.",
                                                    "Well... maybe you won't be doing anymore labor if he hears about this!",
                                                    ()=>
                                                        this.Emotions.Happiness--
                                                );
                                        }
                                    );
                            }
                        );
                    this.Dialog.Add
                        (
                            "I'm sorry, ma'am, but Adam Sandler doesn't work here.",
                            "Not that idiot! I mean my son!",
                            () =>
                            {
                                this.Dialog.Add
                                    (
                                        "Your son is Adam Sandler? Are you Satan?",
                                        "HOW DARE YOU SAY THAT TO YOUR ELDER?! I AM SANTA'S MOTHER!",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "From the way the boss talks about you? I couldn't tell the difference.",
                                                    "I'm sure you're going to be fired when my son hears this.",
                                                    ()=>
                                                        this.Emotions.Happiness--
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Oh, I'm sorry, ma'am. I'm new and didn't quite recognize you. Here, let me put you through.",
                                                    "Just don't let it happen again, son."
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Oh, I'm sorry, ma'am. I thought you were making a reference to that movie.",
                                                    "No, I hate it! Now put me through to my son!",
                                                    ()=>
                                                        this.Emotions.Happiness--
                                                );
                                        }
                                    );
                                this.Dialog.Add
                                    (
                                        "I'm sorry, ma'am. That was a test.",
                                        "A test for what? Why would you be suspicious? Is he avoiding Mrs. Claws?",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "Just a test to make sure it's an important call.",
                                                    "Well, I'd say a call from your mother is important! So if you would just be a dear and let me talk to my son."
                                                );
                                            this.Dialog.Add
                                                (
                                                    "I know how to screen for Mrs. Claws. She just makes odd sounds into the phone. It's the private investigators that the elves have hired that give us trouble.",
                                                    "Oh, my goodness! My son never told me about that! I need to talk to him about this at once."
                                                );
                                            this.Dialog.Add
                                                (
                                                    "A test to see if you were dumb enough to get angry at a dumb joke. Congratulations, you passed with flying colors.",
                                                    "I will NOT tolerate that kind of behavior! I need to speak to Santa -- my son -- right now!",
                                                    () =>
                                                        this.Emotions.Happiness--
                                                );
                                        }
                                    );
                                this.Dialog.Add
                                    (
                                        "I'm sorry, ma'am. He's always been Mr. Claws to me, so I keep forgetting that his name is Nicholas.",
                                        "You sound like such a respectful young snowperson! Are your elf co-workers this respectful, too?",
                                        () =>
                                        {
                                            this.Dialog.Add
                                                (
                                                    "About as much as they can be for being so overworked and underpaid.",
                                                    "Well, may I talk to Santa? I'd like to ask him why he even thinks that's appropriate to treat your fellows like that.",
                                                    () =>
                                                        this.Emotions.Happiness++
                                                );
                                            this.Dialog.Add
                                                (
                                                    "Yeah, they are pretty polite. Santa calls them bearded midgets, though.",
                                                    "He does what?! Oh, that young man is going to get a lesson in manners from me!",
                                                    () =>
                                                        this.Emotions.Happiness++
                                                );
                                            this.Dialog.Add
                                                (
                                                    "About as respectful as a bunch of whiny hobbits can get.",
                                                    "This is so offensive. Look, I need to talk to my son right now!",
                                                    () =>
                                                        this.Emotions.Happiness--
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

            Game.Boss.Emotions.Happiness++;
        }

        void Transferred()
        {
            Game.Boss.Emotions.Happiness--;
        }
    }
}