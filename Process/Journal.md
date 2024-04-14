# Reflecting on the semester
April 14th

A few days ago, we did the presentations in class for our final prototype. I was pretty nervous for mine but it went really well and I got super insightful feedback!

One point that I got that I fully agree with is that my game doesn't quite fit the "fighting game" label that I gave it in the beginning. It was going to be a 2-players street-fighter type game but with words as the weapons/attack moves, but because of how it evolved, it doesn't really match that trope anymore. The person who made the comment suggested it could be considered a puzzle game, but I more or less agree because yes there is a bit of strategy required to craft the perfect insult, but there is also a lot of randomness/fake subjectivity involved and so there's not really one solution that will 100% work against the opponent. Maybe it's a mashup between fighting and puzzle? I think I need to give it a bit more thought.

I wanted to include a "future directions" slide in my pitch, but I ended up forgetting about it, so I'll do it here and now:
Things I would have to think about/implement if/when I continue working on this game in the future:
- Implement the various avatar choices; or, a more advanced option, implement a customization feature for the opponent's look
- AND have the different characters react differently to the insults, i.e. some are easier to offend than others, or they're offended by specific things
- Long term goal: I really do think that the use of some kind of AI to control the opponent's reactions is the ultimate direction this game should take. I actually looked it up during the semester, but the information I found was either too complicated or required me to pay for third-party stuff - perhaps there was a more simple way to implement it, but I didn't find anything about it. And since I know virtually nothing about how artificial intelligence actually works as of now, I thought that it would be better to leave that for later and focus on other aspects of the game for this class. However, I really think that using AI-generated responses from the characters would make for funnier and more dynamic interactions during the player and the opponent. I'll continue looking into that!
- Finally, I'd like to refine the visuals (specifically the opening screen and the game over screens) a little, although I'm pretty satisfied with how they already are
- And I can put the game on itch.io so more people can try it out:)

**A bit of reflecting on the prototyping process?**

I'm gonna be honest, it started out pretty rough. I got excited with my idea in the beginning but then when it came to coding, I spent weeks just making the most basic basic implementation prototype on Unity. Looking back, maybe I could have started with a type of prototype that's closer to the skills I already have, like look/feel, so that I would have had something to share in class earlier. But at the same time, I wanted to take this class because I wanted to learn new coding skills, so I'm glad I didn't shy away from Unity and jumped into it as early as I could, even if it was really difficult and took many weeks before I actually got something that was playable/testable. 

I would say after week 10, the programming went much more smoothly and that's when I really started to feel like I was able to improve my prototype. I often didn't have a lot of time in class to test my game, but I made many of my friends try it in-between classes and each time they would give me feedback, I would take note of it and implement the suggested features into my game.

I still feel like because my programming skills are very new and I'm still a bit slow at figuring things out, I didn't get to make a lot of versions of my game and mostly just added/removed elements from the main version as new ideas came. I think if we had only 1-2 more weeks I could have really dived into more experimentation and variations. 

Overall though, I am super happy with what I managed to do for the final submission, especially since until week 9, I felt super discouraged and thought I wouldn't even be able to make something playable at all. I feel like I learned so many things about Unity, game design, and prototyping, and I feel much more confident. I will definitely continue learning and making games in the future. I am a game designer:]

My final thoughts on this class: I think it was great! My goal with it was to learn how to make games and to improve my programming skills, and I achived both so! Hurray! It was also the jumpstart I needed since I always wanted to know how to make games but never seriously looked into it. Also, even though I only used it for one week, I loved discovering about Bitsy and it's really something I want to use again in the future.

And that concludes this journal! :-]

# Last week!

I got a lot of things done today since the presentation is tomorrow and I wanted to make sure I had at least answered all my questions from last time.

First, a few days ago I implemented the mysterious ??? button of my game. I really struggled to settle on what it would do, but I ended up making it display a random special phrase from a separate bank when it's clicked. I didn't want it to be accessible at all time, so I made it so it would only appear everytime the player makes 2 successful attacks in a row. 

Some other small changes I made are:
- I finetuned the main menu
- I added a ? icon in the main scene which you can click on if you're stuck and need to read the instructions again. A lot of my friends who tested the game were getting frustrated because their attacks didn't work, so I thought that adding this simple feature would help players when that happened!

<br> And of course, the big thing I wanted to figure out before the presentation was the opponent's behavior. So far, the reactions were completely random, and it would get quite frustrating because the effort put into the attacks never really payed off, the enemy could lose a lot of health with just one word or very little with a super hilarious insult.
<br> I procrastinated a bit on this aspect because it felt really intimidating, but today I finally decided to tackle it (and also, time's running out lol). 
<br> I started by writing down the different possibilities for each attack and do a really simplified flow chart. Basically, if the attack consists of nothing, if it has too many cursewords or if it's syntactically incorrect, then it is invalid and the opponent doesn't lose any health. However, if you used the special attack, grammar doesn't apply, and you automatically hit. Then, if the attack is neither invalid nor special, it means there are two possibilities: you either hit or miss.
<br> So then I had to determine what would make you hit or miss. I know I still wanted a bit of randomness, but also I wanted to give the player some control. I chose three elements that would make an attack more powerful:
- The use of really long words (like 10 letters or more)
- More words = more points
- Alliteration, ie when each word starts with the same letter (this was actually suggested by someone during last week's playtests:))

My silly ballpoint pen notes as always: <br>
![434858906_3296674700638058_1223085251646435332_n](https://github.com/marie-anne-decarie/CART-315/assets/157767089/58b5d098-7c16-4d38-8671-6fc994d28305)


I established a points system where you would get a certain number of points for each attack based on those three conditions, and then the more points you have, the more likely your attack is to hit (but not always!)

Another question I wanted to work on was how do you lose this game? I did something pretty simple, basically if you miss too many attacks in a row or don't respect grammar, the opponent makes fun of you and you lose.

Another suggestion I got last week was to have the opponent fight back. What I did is I made two new text resources with a bunch of counter-attacks in them, one for when you hit the opponent, and one for when you miss. The "hit" reactions express how offended he is, while the "miss" ones have witty comebacks and him making fun of the player.

I still have a few details I want to finetune, but I'm really satisfied with where my game is right now. I still think I could work a bit more on art, which I'll try to do before the presentation tomorrow. I had two big animation projects to finish/work on this week and so I kind of neglected the artistic aspect of my game, even though I wanted to work on it. I want to make a final look-and-feel prototype to show really how the interface would look like once the game is finished, and also the different avatars the player could fight against. Another suggestion I got was to make multiple choices of opponent, and I think that a great compromise between having just 1 avatar and a full customization feature. So, I'll try to design a few character concepts for the pitch.

Speaking of which, I started preparing my pitch already, but I will finish it tomorrow once I have all the art and the concepts I want to present.

I think that's everything for now!:-]

# April 4th

I was pretty busy with other classes these past few days, but I still managed to incorporate animation in my game as I wanted! It was a lot more simple than I expected. I animated an avatar with four different reactions that would play whenever the player lauches an attack.
<br> I was more focused on the actual implementation of the animation into Unity than on the character design, so the current design is not particularly interesting. I find it hard to figure out what the opponent should look like in the game, since I want him or her to look like you'd wanna insult them, and that's a bit subjective (for me I guess that would just be some really, really annoying sexist white guy lol)
<br> I thought that there could be a character customization element to the game where the player decided what the guy they're insulting will look like. Perhaps that way there could be a cathartic element where you can make him look like someone you hate or someone you find really frustrating, which I think is pretty funny.
<br> Obviously I don't think I have time to implement the whole customization thing since there's only one week left, but I'll try to draw some concept art for it just to have an idea of what it could look like while focusing on perfecting the actual gameplay.
<br><br> Current guy design: <br>
![idle_01](https://github.com/marie-anne-decarie/CART-315/assets/157767089/9c9aefa9-92da-4048-857f-8e36f52d6e59)
<br> <br> I don't know, I think he looks kinda goofy! It works for the prototype, my friend tried it this morning and she liked his reactions and facial expressions.

# Week 10 - Recap

I worked a lot on my prototype this week and I am very satisfied with where everything is headed. My goal was to (at last) have a fully playable prototype that I could test with other people without having to be like "it's supposed to do that here" or "aah yeah I'm not done coding this part". 
<br> Before I started, here are some of the suggestions that I got in class last thursday:
- give a point value to some of the words so that there are common and rare ones which are worth more or less points
- Limit either the time of attack or the amount of words permitted per attack
- Maximize the wordbank by keeping the words in a text asset file and using it as a resource
-  Play against the computer instead of against another player (use AI? Perhaps? Or else just make the reactions a little random)

<br> I worked two separate times on my prototype over the week. The first time, I put the words into a resource file as suggested, which made everything 10000x more simple than what I had been trying to do so far (thanks Matt). I tried to organize the UI in a more visually pleasing way and added buttons for punctuation, additional swear words and a mysterious button (which I still haven't figured out what it does, but I know I will find something). I then added an opponent against which to play, and implemented a health bar as well as possible reactions for him. Then I also added a game over screen that allows you to play again once you defeated the opponent.
<br> At the end of that work session, I made a list of the things to improve for next time:<br>

![430937933_930975168778370_9111604240852797778_n](https://github.com/marie-anne-decarie/CART-315/assets/157767089/962a4c90-0fa4-43dc-bfc3-058117aae10f) <br>

<br> At this point, I had two of my friends try the work in progress and they seemed to enjoy it!:3 One of them suggested that there could be a few different opponents, and that depending on which one you attack, the reactions as well as the health bar management could be different.

<br> The second time I worked on my prototype, I went through my to-do list and fixed most of the things there. I implemented some "rules" that force you to respect a certain level of syntax, example you can't put an adjective after a noun and there's a maximum number of adjectives (so the insults aren't ridiculously long). I'd like to make it a bit more dynamic later on, such that the longer you play, the longer insults you're allowed to make, but I still need to figure that out.
<br> I made the words momentarily disappear after each attack (to block the player from attacking too fast) and then reshuffle at each turn, so that it would be more interesting. I also tweaked the opponent's reaction such that there are specific reactions when you attack without saying anything or when you overuse the swear word option. I looked up some videos about AI and tried to see how realisticly I could make the opponent's reaction based on AI, but I didn't get very far so I'll keep thinking about it. For now the reactions are completely random, which I'd like to improve because the game gets a little boring when the reactions don't match the level of effort put into the attack.
<br> Finally, I added a title screen with a play button as well as instructions. I thought that would be useful when playtesting because I wouldn't have to explain anything to the testers. I had my sister test that version of my game and she thought it was a very nice addition.

<br> <br> I also remembered the questions I wrote a few weeks ago so here's where I am with them: <br>
- What are the specific rules of this game (turns, points, how to win, etc.)? **I think that's pretty well established now! You play alone against the computer, you craft attacks from random selections of words and the opponent loses health based on how offended he was. You win when he has no health left! I guess I have to figure out a way to lose too...** 
- How can I make the wordbank funnier to more people and less reliant on offensive language? **I think my current wordbank is really funny, and the people that tested my game confirmed it. Some of the words are really unusual and it makes some really absurd insults, plus I removed most of the offensive language because it made it too easy and not comedic at all**
- How to make a basic version of it in Unity without overcomplicating things? **Again, I think I pretty much figured it out by now! Unity can't defeat me >:)**

<br> <br> For this week, I want to focus less on code and more on art so my game looks nicer. I also want to test Unity's animation more in depth (even though I already tested it a little bit with my title screen). Here are the questions I'll try to answer:
- How can I use animation to make the opponent feel more lively and reactive?
- How do you *lose* this game? Can the opponent fight you back?
- What does the mystery "???" button does?

<br> And that's it for now!


# Week 9 - Prototyping

This week, the first thing I did was improve my paper prototype. As I mentioned, I didn't like the word bank I had and I also wanted to make it bigger. So, I went on the internet and searched for funny or unusual english words and managed to gather a pretty large bank of 50-ish nouns + 50-ish adjectives. It was a fun process and I'm much happier with the words I have now.<br>
![431295675_272001272620302_8570431211418355420_n](https://github.com/marie-anne-decarie/CART-315/assets/157767089/6e678a92-974e-442e-a410-0b082f316fce)

<br> Then, I wanted to tackle coding. I started over with a new scene because my first attempt at a prototype from last week was not working at all. It still feels pretty incomplete, but with my level of skill I'm pretty satisfied with what I managed to achieve. Here's what you can do so far in my game:
- Get a random selection of nouns and adjectives
- Click on the nouns and adjectives to craft an insult. The words you click on are displayed on the screen
- When you click on the words, points are displayed on the screen
- There is an "attack" button that launches the attack, i.e. removes the words from the screen and calculate the final score. So far, there is no turns mechanic, so you can't actually attack another player.

<br> For this to feel really complete, I would have wanted to add a time limit for the attack as well as a turns mechanic so that two players can craft insults one after the other. For now, all I managed to do was have a button to reload the screen and thus allow for a new turn to start.
<br> For the specific rules, unfortunately, I still did not have the occasion to test this with actual people. I was really focused on the actual coding aspect (which always takes me the longest) and didn't invite other people to try the rules I had thought, so they might still need some tweaking. 

<br> For now, here are the notes I took this week in my notebook: <br>
![431164937_743605360874713_1674959852223639574_n](https://github.com/marie-anne-decarie/CART-315/assets/157767089/b4fc973a-ea7f-49c6-86d8-d4c2dedabc30)
![432830612_883991330404367_8537851732378745853_n](https://github.com/marie-anne-decarie/CART-315/assets/157767089/d05e407c-d631-438a-82e0-62d66da1e835)

# March 9th - Reflecting on this week's playtest

The playtest in class went pretty well! I didn't have a lot of time to actually test my game, but I showed the concept art and the paper prototype to other people and they said they liked the idea a lot. They already gave some suggestions to improve it, like make the words more unexpected and random as opposed to regular swear words/insult (which I totally agree with, I think the initial word bank I came up with ended up being way too reliant on those).
<br> I talked a bit about the turns mechanic as well. In my mind, both player would craft their attack at the same time from a shared words bank in a limited time, but someone proposed alternate turns instead, with a strict time limit. Each round, one player could attack first and the second gets a chance to defend themselves, or both pick a word each their turn until both attacks are ready. 
<br> One thing I was worried about is the fact that this game concept already exists. I talked about it with others and they didn't think it was a big deal, since knowing it already existed now, I could just get inspired from it and also make sure that mine was different enough to stand out. This reassured me and I will carry on with this project despite my initial concerns.
<br> For now, the first thing I want to do is improve the paper prototype (since the one I did was a bit minimalistic) and test it for a bit longer with my friends, since as I mentioned, we ran out of time in class to really test it well. After that, I'll try to start coding. I already tried making a Unity prototype last week, but it didn't go well at all and I didn't even show it in class. I think I definitely tried to go too fast. All I managed to do was shuffle the words from the bank and display a few of them in the right slots on screen. I think I can build up on this and make something really simple just to showcase how this game will be played.
<br> Going forward, the questions I'll try to answer are:
- What are the specific rules of this game (turns, points, how to win, etc.)?
- How can I make the wordbank funnier to more people and less reliant on offensive language?
- How to make a basic version of it in Unity without overcomplicating things?

<br><br> Here's what I had to show in class: <br>
![wordsFightWordArt](https://github.com/marie-anne-decarie/CART-315/assets/157767089/8b28be13-f6e7-4299-b58c-e6c49df5f552)<br>
![UISketch](https://github.com/marie-anne-decarie/CART-315/assets/157767089/50a6795f-8637-4827-8dd1-cc3aeac28c5b)<br>
![TitleArt](https://github.com/marie-anne-decarie/CART-315/assets/157767089/f21b09ca-c093-43d0-8c5c-38b4051ac37b)<br>

<br> That's it for now!

# March 7th

*So, turns out my idea already exists...*
<br><br> I just showed my (very rough) prototype to my friend, and she goes "girl...that's already a thing..."
<br> I should have looked it up!:( <br>
![oh sir](https://github.com/marie-anne-decarie/CART-315/assets/157767089/0f6bbfce-5533-40e2-937e-4e19ec9ae6ac) <br>
Honestly these past two weeks have been a little rough. I tried to do too much and too fast. I wanted to get ahead and have a Unity prototype to show in class, but I really overestimated my coding skills and I wasn't able to do much except shuffle the words and show them on screen. At least I have some paper material, but again, the "the idea already exists now" thing really worries me. We'll see what happens when I show it in class!

# March 4th
<br><br> I've been thinking a bit more about the words fighting game. I think it could be really fun, even though I'm not entirely sure about the rules and gameplay.
<br> I realized I forgot to write actual design values like we discussed last week so here goes:
- Experience/emotion: This game has to be funny for the player(s). The game should be fast-paced enough to force the player to choose his words quickly and come up with something a little absurd, without too much overthinking. The game should also be just a tasteful amount of offensive (it is a fighting game, it needs a bit of violence, verbal in this case)
- Aesthetic: The way the game looks has to add to the comedy. I envision comical animations when the avatar attacks or receives an attack. I like the idea of the characters literally throwing physical words or speech bubbles at each other (it reminds me a little of something they do in the animated show Tuca and Bertie, where a character will say something and literal letters will come out of their mouth and interact with the environment). The color palette should also be bright and eye-catching, as far from boring as possible!

<br><br> Problem statement: How can I make the concept of cards against humanity into a 1v1 street-fighter-type game?

# Reading week (6.5? 7?) - Ideation process

**February 29** <br>
<br> I've been thinking a lot about game ideas these past few days and I couldn't really find anything that stuck, but then suddenly last night at 2AM my brain started working again!! I have plenty of inspiration now!
<br> I realized that I was feeling super bored lately and I got the idea of making a game both *about* boredom and that helps *fight* (or perhaps *embrace*) it. I made a mind map: <br> <br>
![boredomMindMap](https://github.com/marie-anne-decarie/CART-315/assets/157767089/2e71cc51-d6f9-4d0b-88f4-d220b65d19c2)
The actual notes I took on my phone at 2AM: <br>
![2AM notes](https://github.com/marie-anne-decarie/CART-315/assets/157767089/e09a65f4-516e-4efc-8f80-20a4e12f1af2)
<br>(the words fighting game doesn't quite work with this theme and it's less funny now than it was in my head 10 hours ago
but still... I think it has potential. I'll get back to it later!)<br>
Back to the boredom idea, I don't just want to make a game to play *when you're bored* (which there are already tons of), but rather one that explores boredom and other related things as central thematics and where the goal is explicitely to exploit boredom in a playful way, perhaps still making you waste your time, but with self-awareness!

<br><br> Mecanic ideas that play with boredom, time perception and procrastination:
- Time manipulation: certain actions make time in the game advance slower or faster
- The game gives you tasks and the goal is to complete as little as possible
- A survival game and the thing that is trying to kill you is the deadline/ your responsibilities
- A daydreaming mode where time is stretched and everything becomes aesthetically brighter and more colorful

<br> CONCRETE IDEAS:
1. **Bore me: a game to waste time on purpose**. You click the "bore me" button and it generates a series of mini-games that you can play to pass time. The mini-games are all based around the theme of procrastination, fidget toys and stupid things you do when you're bored. Perhaps it starts with a few questions like "how easily are you bored" and "how long do you want to be bored for" and then craft a personalized series of mini-games for you. At the end, you chose between "I'm bored now" and "Bore me again". It's partly inspired by this website that takes you to a random useless website every time you click the button: [theuselessweb](https://theuselessweb.com/), except with games instead of websites and some level of customization. 
2. **Daydream Disaster** (working title) A game about escapism from reality and distorted perceptions of time. There's a progress bar that fills up as you get closer and closer to a deadline. The goal is to push it back for as long as possible by playing different tasks/mini-games that make time slower. The most efficient methods to waste time also give you the most psychic damage. The UI ressembles a phone or desktop with apps and notifications (game examples: *A Normal Lost Phone*, *Simulacra*) 
3. **Words fight**. This idea is quite different from everything I talked about so far but I still think it's worth writing down! It's a 1v1 fighting game that uses words and speech bubbles instead of weapons, with a Cards Against Humanity-like mecanic. You craft your 'weapons' by filling the blanks in a sentence, creating the most creative/shocking/offensive insult or comeback as possible. The most shocking or funny your words, the more it hurts your opponent. I have no idea how the points system work as of right now. In CAH, there's always a neutral person that judges who picked the funniest card, but in this game, perhaps the judge is the computer, or each word option comes with a pre-established amount of points and combining certain words cause more damage, and there's joker cards where the player can craft his or her own witty comeback to attack the opponent. I guess that's the design goal here: making a game that adapts a CAH-type game into a 1v1 fighting mode.
![words fight sketch](https://github.com/marie-anne-decarie/CART-315/assets/157767089/0eaa0c59-8ce2-440b-b57b-df2cf89aced1)
<br> Back to the points system: maybe the game has some predefined words that are worth a certain numbers of points, but then there's a bunch of customizable cards and the players basically build their own set of words before the game start based on what they think is funny. There would be some guidelines, like "write the uggliest thing possible" or "your favorite insult" or "a very shocking adjective" or whatever. So the game takes care of the mecanical/points-counting part but the players are responsible for building the creative/humoristic part.  





# Week 5 - Game analysis

The game I chose to talk about is Super Mario Bros. 3 for the NES because I was obsessed with it when I was 11 and
I'm currently looking to buy a NES so I can play old games for nostalgia:')
<br> I decided to make a list of what I consider good and less good design elements in this game (I guess some of
it will sound very obvious since this is a very widely loved game after all but I'll try to find some more
niche elements):
<br> PROS:
- The levels are organized very neatly and give a nice sense of progression. I guess it's become pretty basic
by today's standards but that game was the first
Mario game to be organized into worlds with their own respective layouts, maps, visual theme and aesthetic, music, and levels.
Maybe I'm biased because I love 80s-90s games aesthetic but the layout of the maps look so neat with the little squares
for each level and the castle icons and the various mini-games/powerups
- The sound design is simple yet iconic
- I find that the new flying mecanic that comes with the racoon power up in this game is actually one of the coolest
features of this game. I love the arrows that fill up as you gather up speed and the beeping that indicates that you're going
fast enough to take flight. I also like that the beeping matches the controls for flying which is basically just rapidly
pressing a button for your life.
  
<br> CONS:
- I think the side-scrolling levels are often way too fast, which makes them literal hell.
- I find that a lot of the really interesting powerups (like the tanooki suit and frog suit)
are actually extremely scarce in the game, with very few rare occasions
to try them
- I actually refuse to believe that some of the levels in this game were properly tested, especially those in the later levels.
Two specific memories I have of ridiculous levels are:
1.  a haunted house in which the only way out was through a door hidden in a
random off-screen location such that the only way to find it was to randomly fly up every corner of the room (which was pretty
wide) until you find it.
2. the majority of levels in the pipe-themed world where you basically have to enter random
pipes over and over until you find the right combinason that brings you to the end, with most pipes actually leading you
back to the start of the level. Not cool nintendo>:(
- Also one thing I never understood about Mario games is how the points work. Everything you do gives you points but
then they are never used for anything. You don't need them to pass from one world to another. You can't buy powerups
or whatever with them. Update: I looked it up and apparently the scoring in the original Mario games was basically there
to make the player feel good when he or she gets a really big score even if it means nothing. Pretty funny methinks
