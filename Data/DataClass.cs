using F1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace F1.Data
{
    public class DataClass
    {
        public static New TempNew = new New();
        public static void Initialize(SiteContext context)
        {
            
            if (!context.Team.Any())
                context.Team.AddRange(
                    new Team
                    {
                        Name = "Ferrari",
                        FullName = "Scuderia Ferrari",
                        Base = "Maranello, Italy",
                        Chief = "Mattia Binotto",
                        Power = "Ferrari",
                        TeamEntry = "1950",
                        Championships = 16,
                        Poles = 233,
                        FastesLaps = 256,
                        Points = 157,
                        Position = 1,
                        Description = "For many, Ferrari and Formula 1 racing have become inseparable. The only team to have competed in every season since the world championship began, the Prancing Horse has grown from the humble dream of founder Enzo Ferrari to become one of the most iconic and recognised brands in the world. Success came quickly through the likes of Alberto Ascari and John Surtees, and continued – in amongst leaner times – with Niki Lauda in the 1970s and then Michael Schumacher in the 2000s, when Ferrari claimed a then unprecedented five consecutive title doubles, securing their status as the most successful and decorated team in F1 history...",
                        Preview = "/img/teams/preview/preview_ferrari.png",
                        Logo = "/img/teams/logo/logo_ferrari.jpg",
                        Img = "/img/teams/team/ferrari.jpg",
                        FirstDriver = "Charles Leclerc",
                        SecondDriver = "Carlos Sainz"
                    },
                    new Team
                    {
                        Name = "Red Bull",
                        FullName = "Oracle Red Bull Racing",
                        Base = "Milton Keynes, United Kingdom",
                        Chief = "Christian Horner",
                        Power = "Red Bull Powertrains",
                        TeamEntry = "1997",
                        Championships = 4,
                        Poles = 75,
                        FastesLaps = 78,
                        Points = 151,
                        Position = 2,
                        Description = "Red Bull were no strangers to F1 - as sponsors - prior to formally entering as a works team in 2004. Nonetheless, the scale of their success over the following decade was staggering. After a first podium in 2006, the team hit their stride in 2009, claiming six victories and second in the constructors' standings. Over the next four seasons they were a tour de force, claiming consecutive title doubles between 2010 and 2013, with Sebastian Vettel emerging as the sport's youngest quadruple champion. Now their hopes of recapturing that glory lie with an equally exciting talent – one named Max Verstappen…",
                        Preview = "/img/teams/preview/preview_redbull.png",
                        Logo = "/img/teams/logo/logo_redbull.jpg",
                        Img = "/img/teams/team/redbull.jpg",
                        FirstDriver = "Max Verstappen",
                        SecondDriver = "Sergio Perez"
                    },
                    new Team
                    {
                        Name = "Mercedes",
                        FullName = "Mercedes-AMG Petronas F1 Team",
                        Base = "Brackley, United Kingdom",
                        Chief = "Toto Wolff",
                        Power = "Mercedes",
                        TeamEntry = "1970",
                        Championships = 8,
                        Poles = 127,
                        FastesLaps = 85,
                        Points = 95,
                        Position = 3,
                        Description = "Mercedes’ modern F1 revival started with the creation of a works squad for 2010 - the platform for a meteoric rise up the Grand Prix order. The team generated huge excitement from the off with the sensational return of Michael Schumacher, but headlines soon followed on track: three podiums in their debut season, all via Nico Rosberg - who then claimed a breakthrough pole/victory double at China in 2012. The following season he was paired with Lewis Hamilton, the duo going on to stage some epic title battles as the Silver Arrows swept all before them to become one of the most dominant forces of the modern F1 era. And with Hamilton now partnered by steely Finn Valtteri Bottas, Mercedes remain very much the team to beat…",
                        Preview = "/img/teams/preview/preview_mercedes.png",
                        Logo = "/img/teams/logo/logo_mercedes.jpg",
                        Img = "/img/teams/team/mercedes.jpg",
                        FirstDriver = "George Russell",
                        SecondDriver = "Lewis Hamilton"
                    },
                    new Team
                    {
                        Name = "McLaren",
                        FullName = "McLaren F1 Team",
                        Base = "Woking, United Kingdom",
                        Chief = "Andreas Seidl",
                        Power = "Mercedes",
                        TeamEntry = "1966",
                        Championships = 8,
                        Poles = 156,
                        FastesLaps = 160,
                        Points = 46,
                        Position = 4,
                        Description = "Since entering the sport in 1966 under the guidance and restless endeavour of eponymous founder Bruce, McLaren's success has been nothing short of breathtaking. Five glittering decades have yielded countless victories, pole positions and podiums, not to mention eight constructors' championships. What's more, some of the sport's greatest drivers made their names with the team, including Emerson Fittipaldi, Ayrton Senna, Mika Hakkinen and Lewis Hamilton...",
                        Preview = "/img/teams/preview/preview_mclaren.png",
                        Logo = "/img/teams/logo/logo_mclaren.jpg",
                        Img = "/img/teams/team/mclaren.jpg",
                        FirstDriver = "Lando Norris",
                        SecondDriver = "Daniel Ricciardo"
                    },
                    new Team
                    {
                        Name = "Alfa Romeo",
                        FullName = "Alfa Romeo F1 Team ORLEN",
                        Base = "Hinwil, Switzerland",
                        Chief = "Frédéric Vasseur",
                        Power = "Ferrari",
                        TeamEntry = "1993",
                        Championships = 0,
                        Poles = 1,
                        FastesLaps = 5,
                        Points = 31,
                        Position = 5,
                        Description = "The name Alfa Romeo boasts Formula 1 connections dating back to the championship’s inception in 1950. Fast forward to the 21st century and Italian flare combines with Swiss sensibilities in a new era for the team formerly known as Sauber. Having enjoyed considerable success in world sportscars, where he helped nurture the emerging talents of future F1 stars Michael Schumacher and Heinz - Harald Frentzen, Peter Sauber guided his eponymous squad into F1 in 1993. The team has since established itself as a mainstay of the grid, becoming race winners under BMW’s brief ownership, and developing a well - earned reputation not only for producing competitive cars, but also for developing young drivers.",
                        Preview = "/img/teams/preview/preview_alfaromeo.png",
                        Logo = "/img/teams/logo/logo_alfaromeo.png",
                        Img = "/img/teams/team/alfaromeo.jpg",
                        FirstDriver = "Valtteri Bottas",
                        SecondDriver = "Zhou Guanyu"
                    },
                    new Team
                    {
                        Name = "Alpine",
                        FullName = "BWT Alpine F1 Team",
                        Base = "Enstone, United Kingdom",
                        Chief = "Otmar Szafnauer",
                        Power = "Renault",
                        TeamEntry = "1986",
                        Championships = 2,
                        Poles = 20,
                        FastesLaps = 15,
                        Points = 26,
                        Position = 6,
                        Description = "Alpine may be a relatively new name to Formula 1, but Renault’s famous sportscar arm has plenty of motorsport heritage. The 2021 rebrand of the team marked the next step in Renault’s F1 revival, begun in 2016 with the takeover of the then-Lotus squad. Already race winners in their new guise, regular podiums and a tilt at the title must be their next target…",
                        Preview = "/img/teams/preview/preview_alpine.png",
                        Logo = "/img/teams/logo/logo_alpine.jpg",
                        Img = "/img/teams/team/alpine.jpg",
                        FirstDriver = "Esteban Ocon",
                        SecondDriver = "Fernando Alonso"
                    },
                    new Team
                    {
                        Name = "AlphaTauri",
                        FullName = "Scuderia AlphaTauri",
                        Base = "Faenza, Italy",
                        Chief = "Franz Tost",
                        Power = "Red Bull Powertrains",
                        TeamEntry = "1985",
                        Championships = 0,
                        Poles = 1,
                        FastesLaps = 2,
                        Points = 16,
                        Position = 7,
                        Description = "Established in 2006 as a squad in which young drivers from Red Bull’s prodigious talent pool could cut their F1 teeth, AlphaTauri – originally named Toro Rosso – were formed from the ashes of the plucky Minardi team. Sebastian Vettel gave validity to the approach almost immediately, delivering a fairy-tale win in 2008, before going on to enjoy world championship success with parent team Red Bull Racing. Today the ethos of nurturing talent still holds true, though the Italian squad are no longer simply a ‘B team’ but a constructor in their own right...",
                        Preview = "/img/teams/preview/preview_alphatauri.png",
                        Logo = "/img/teams/logo/logo_alphatauri.jpg",
                        Img = "/img/teams/team/alphatauri.jpg",
                        FirstDriver = "Yuki Tsunoda",
                        SecondDriver = "Pierre Gasly"
                    },
                    new Team
                    {
                        Name = "Haas",
                        FullName = "Haas F1 Team",
                        Base = "Kannapolis, United States",
                        Chief = "Guenther Steiner",
                        Power = "Ferrari",
                        TeamEntry = "2016",
                        Championships = 0,
                        Poles = 0,
                        FastesLaps = 2,
                        Points = 15,
                        Position = 8,
                        Description = "The youngest team on the grid, Haas made their highly impressive debut in 2016, and in the process became the first all-American-led F1 squad in three decades. Founded by industrialist Gene Haas, they are based in the United States on the same Kannapolis, North Carolina facility as his championship-winning NASCAR Sprint Cup Series team, Stewart-Haas Racing. The Ferrari-powered team, led by the charismatic Guenther Steiner, also have a UK factory in Banbury…",
                        Preview = "/img/teams/preview/preview_haas.png",
                        Logo = "/img/teams/logo/logo_hass.jpg",
                        Img = "/img/teams/team/haas.jpg",
                        FirstDriver = "Kevin Magnussen",
                        SecondDriver = "Mick Schumacher"
                    },
                    new Team
                    {
                        Name = "Aston Martin",
                        FullName = "Aston Martin Aramco Cognizant F1 Team",
                        Base = "Silverstone, United Kingdom",
                        Chief = "Mike Krack",
                        Power = "Mercedes",
                        TeamEntry = "2018",
                        Championships = 0,
                        Poles = 1,
                        FastesLaps = 0,
                        Points = 6,
                        Position = 9,
                        Description = "Aston Martin’s original Formula 1 foray – over half a century ago – lasted just five races. This time, though, it’s serious. This F1 squad are no strangers to success, having won in their original guise of Jordan and most recently as Racing Point in 2020. Renowned for their ability to punch above their weight, and now with a four-time champion leading their driver line-up, Aston Martin are very much a team to watch…",
                        Preview = "/img/teams/preview/preview_aston.png",
                        Logo = "/img/teams/logo/logo_aston.jpg",
                        Img = "/img/teams/team/aston.jpg",
                        FirstDriver = "Sebastian Vettel",
                        SecondDriver = "Lance Stroll"
                    },
                    new Team
                    {
                        Name = "Williams",
                        FullName = "Williams Racing",
                        Base = "Grove, United Kingdom",
                        Chief = "Jost Capito",
                        Power = "Mercedes",
                        TeamEntry = "1978",
                        Championships = 9,
                        Poles = 128,
                        FastesLaps = 133,
                        Points = 3,
                        Position = 10,
                        Description = "Driven on by the brilliance and passion of the late Sir Frank Williams, Williams grew from humble beginnings to become a Formula 1 behemoth, unrivalled by all except Ferrari and McLaren in terms of enduring success. Over the past four decades the team has racked up Grand Prix wins and championship glory, and in the process nurtured some of the greatest talents in the sport, both in and out the cockpit. Now, following the Williams family's decision to step aside after the sale of the team to Dorilton Capital, a new era begins...",
                        Preview = "/img/teams/preview/preview_williams.png",
                        Logo = "/img/teams/logo/logo_williams.jpg",
                        Img = "/img/teams/team/williams.jpg",
                        FirstDriver = "Alexander Albon",
                        SecondDriver = "Nicholas Latifi"
                    });

            if(!context.Driver.Any())
               context.Driver.AddRange(
                   new Driver
                   {
                        Name = "Charles Leclerc",
                        Country = "Monaco",
                        Team = "Ferrari",
                        DateOfBirth = "16/10/1997",
                        Number = 16,
                        Podiums = 17,
                        Races = 86,
                        Points = 104,
                        Position = 1,
                        Championships = 0,
                        Description = "Born in the Mediterranean idyll of Monaco, Leclerc arrived in F1 on a tidal wave of expectation.\n" +
                               "Practically peerless on his way to the GP3 and Formula 2 crowns, he showcased a dazzling array of skills from scorching pole positions, commanding victories – even when his car caught fire twice at Silverstone – to an ability to muscle his way through the pack.Winning back - to - back championships also taught Leclerc how to handle pressure, another useful tool in the big pond of Formula 1 racing. \n" +
                               "Stepping up to F1 in 2018, Leclerc showed flashes of ballistic pace on Saturdays and racing brilliance on Sundays, dragging his Sauber beyond its limits – and earning himself a money - can’t - buy race seat at Ferrari for 2019, stepping into the shoes of the Scuderia’s last world champion, Kimi Raikkonen. \n " +
                               "There he immediately put the cat among the proverbial pigeons, unafraid to go wheel - to - wheel with established number one, Sebastian Vettel.A maiden F1 victory at Spa was followed by another a week later on Ferrari’s hallowed home turf of Monza.The tifosi had found another new hero – who then became the first man to out-score Vettel over a season with the Scuderia, a feat he repeated in crushing fashion the following year. \n" +
                               "Out of the car, Leclerc is modest and thoughtful - but then he is on his own very personal mission.This exciting young talent is racing for his late father Herve and his friend and mentor Jules Bianchi, the F1 driver who died in 2015. \n " +
                               "On the evidence so far, he is doing them both proud.",
                        Preview = "/img/drivers/preview/leclerc.png",
                        Helmet = "/img/drivers/helmet/leclerc.png",
                        Img = "/img/drivers/driver/leclerc.jpg"
                   },
                   new Driver
                   {
                       Name = "Carlos Sainz",
                       Country = "Spain",
                       Team = "Ferrari",
                       DateOfBirth = "01/09/1994",
                       Number = 55,
                       Podiums = 9,
                       Races = 146,
                       Points = 53,
                       Position = 5,
                       Championships = 0,
                       Description = "He’s the matador from Madrid racing royalty. \n" +
                           "After entering F1’s Bull Ring paired alongside Max Verstappen at Toro Rosso in 2015, Sainz quickly showed his fighting spirit. A tenacious racer, he puts the car on the edge as he hustles his way through the pack. No wonder Sainz has earned the nickname Chilli. \n" +
                           "But the Spaniard is intelligent as well as instinctive, thinking his way through a race and into the points. This calm temperament follows him off track where he remains unfazed by the pressures of forging a Grand Prix career with a famous name.  \n " +
                           "Sainz is the son of double World Rally champion, also his namesake, and has brought some of Dad’s driving skills to the F1 circuit – junior loves a delicious dose of drift for one. \n" +
                           "After following in his famous father’s tyre tracks, Sainz has had big racing boots to fill – first at McLaren where he replaced his childhood hero Fernando Alonso, and now at Ferrari, in the seat formerly owned by Sebastian Vettel. It is never easy living in the shadow of sporting giants, but Sainz has shown the drive and disposition to deal with it. Vamos!",
                       Preview = "/img/drivers/preview/sainz.png",
                       Helmet = "/img/drivers/helmet/sainz.png",
                       Img = "/img/drivers/driver/sainz.jpg"
                   },
                   new Driver
                   {
                       Name = "Max Verstappen",
                       Country = "Netherlands",
                       Team = "Red Bull",
                       DateOfBirth = "30/09/1997",
                       Number = 1,
                       Podiums = 63,
                       Races = 146,
                       Points = 85,
                       Position = 2,
                       Championships = 1,
                       Description = "He’s Max by name, and max by nature. \n" +
                           "Arriving as Formula 1’s youngest ever competitor at just 17 years old, Verstappen pushed his car, his rivals and the sport’s record books to the limit. The baby-faced Dutchman with the heart of a lion took the Toro Rosso – and then the Red Bull – by the horns with his instinctive racing style. \n" +
                           "F1’s youngest points scorer soon became its youngest race winner – at the age of 18 years and 228 days – with an opportunistic but controlled drive on debut for Red Bull in Barcelona 2016. A true wheel-to-wheel racer, another stunning drive in Brazil from the back of the pack to the podium on a treacherous wet track kept the plaudits coming. \n " +
                           "Verstappen’s no-holds-barred attitude and hard defending have sometimes landed him in hot water with his peers and paymasters. But the mistakes that initially marred his potential have given way to maturity, while the bravado and energy that make him a blockbuster talent have remained – and the victories have kept on coming, culminating in his first F1 drivers’ title following that already legendary, final-round showdown with Lewis Hamilton in 2021. \n" +
                           "Having become the Netherlands' first world champion aged just 24, the expectations for the next generation’s leading light are sky high – but with Verstappen there’s a feeling that the sky’s the limit.",
                       Preview = "/img/drivers/preview/verstappen.png",
                       Helmet = "/img/drivers/helmet/verstappen.png",
                       Img = "/img/drivers/driver/verstappen.jpg"
                   },
                   new Driver
                   {
                       Name = "Sergio Perez",
                       Country = "Mexico",
                       Team = "Red Bull",
                       DateOfBirth = "26/01/1990",
                       Number = 11,
                       Podiums = 17,
                       Races = 219,
                       Points = 66,
                       Position = 3,
                       Championships = 0,
                       Description = "He’s the fighter with a gentle touch from the land of the Lucha Libre. \n" +
                           "Perez’s reputation in F1 has been built on opposite approaches to Grand Prix racing. On the one hand, he is a punchy combatant who wrestles his way through the pack and into the points. Never afraid to add a bit of spice to his on-track encounters, even his team mates don’t always escape the Mexican’s heat. \n" +
                           "Then on the other hand, Perez is a smooth operator, a master at managing tyres to eke out extra performance and give him the upper hand on strategy. A firm favourite on the grid after his time with Sauber, McLaren, Force India and Racing Point, Perez has matured into an analytical racer and team player. \n " +
                           "A proud countryman, the Guadalajara gunslinger has amassed more points than any other Mexican in the history of F1. In Sakhir 2020 he also matched hero and compatriot Pedro Rodriguez by taking the chequered flag in first – a performance that landed him a seat with title contenders Red Bull. \n" +
                           "There he provided strong support to Max Verstappen’s 2021 championship-winning campaign, also adding another victory to his own tally. More wins may not be assured, especially with Verstappen as team mate, but Perez working hard and racing with his heart are.",
                       Preview = "/img/drivers/preview/perez.png",
                       Helmet = "/img/drivers/helmet/perez.png",
                       Img = "/img/drivers/driver/perez.jpg"
                   },
                   new Driver
                   {
                       Name = "George Russell",
                       Country = "United Kingdom",
                       Team = "Mercedes",
                       DateOfBirth = "15/02/1998",
                       Number = 63,
                       Podiums = 2,
                       Races = 65,
                       Points = 59,
                       Position = 4,
                       Championships = 0,
                       Description = "He’s the driver with the motto: “If in doubt, go flat out”. \n" +
                           "George Russell has lived by it in his F1 career to date, out-qualifying seasoned team mate Robert Kubica at all 21 Grands Prix in his rookie season, putting Williams back on the podium in 2021, and landing a Mercedes race seat alongside Lewis Hamilton for 2022. \n" +
                           "That brilliant baseline speed served Russell well as he totted up titles on his way to Formula 1. The Briton stormed to the 2017 GP3 championship and delivered the 2018 Formula 2 crown under immense pressure. \n " +
                           "He kept his head down at Williams in 2021, scoring his first points and podium, all the while keeping his eye on the bigger prize. Having proved himself a hard worker and a tenacious talent, that prize arrived in the form of a chance to take on compatriot and seven-time champion Hamilton in identical machinery. \n" +
                           "A huge challenge, but as always, ‘Russell the Rocket’ will be going flat out.",
                       Preview = "/img/drivers/preview/russell.png",
                       Helmet = "/img/drivers/helmet/russell.png",
                       Img = "/img/drivers/driver/russell.jpg"
                   },
                   new Driver
                   {
                       Name = "Lewis Hamilton",
                       Country = "United Kingdom",
                       Team = "Mercedes",
                       DateOfBirth = "07/01/1985",
                       Number = 44,
                       Podiums = 183,
                       Races = 293,
                       Points = 36,
                       Position = 6,
                       Championships = 7,
                       Description = "‘Still I Rise’ – these are the words emblazoned across the back of Lewis Hamilton’s helmet and tattooed across his shoulders, and ever since annihilating expectations with one of the greatest rookie performances in F1 history in 2007, that’s literally all he’s done: risen to the top of the all-time pole positions list ahead of his hero Ayrton Senna, surged into first place in the wins column surpassing the inimitable Michael Schumacher, and then matched the legendary German’s seven world titles. \n" +
                           "Is he the G.O.A.T? Few would deny that he’s in the conversation – and what’s more he’s got there his way, twinning his relentless speed with a refusal to conform to stereotypes for how a racing driver should think, dress or behave. \n" +
                           "Respect is hard earned in F1, but Hamilton – now Sir Lewis Hamilton to be precise – has it from every one of his peers. Why? Because they know that whatever the track, whatever the conditions, whatever the situation, when his visor goes down and the lights go out, it’s Hammertime.",
                       Preview = "/img/drivers/preview/hamilton.png",
                       Helmet = "/img/drivers/helmet/hamilton.png",
                       Img = "/img/drivers/driver/hamilton.jpg"
                   },
                   new Driver
                   {
                       Name = "Lando Norris",
                       Country = "United Kingdom",
                       Team = "McLaren",
                       DateOfBirth = "13/11/1999",
                       Number = 4,
                       Podiums = 6,
                       Races = 65,
                       Points = 35,
                       Position = 7,
                       Championships = 0,
                       Description = "Lando Norris may not be named after Star Wars rebel Lando Calrissian - his Mum just liked the moniker - but he has flair and fighting spirit in bountiful supply. \n" +
                           "McLaren had the British teenager on their books for two years before fast-tracking him into F1’s galaxy of stars in 2019. A firecracker in his junior career, with a penchant for pole positions and wheel-to-wheel tussles, Norris didn’t let them down. \n" +
                           "Paired with the highly-rated – and far more experienced – Carlos Sainz, his rookie season was impressive, edging the Spaniard in their head-to-head qualifying battle, scoring points on 11 occasions, and only narrowly missing out on a top-10 championship placing. It was a similar pattern in 2020, with the affable Brit securing a maiden podium and moving up to ninth overall. \n " +
                           "His unstoppable rise continued in 2021, with a further four podiums and almost a race win as he dominated another more senior team mate, Daniel Ricciardo, to move up to P6 in the final driver standings. \n" +
                           "Norris hopes the downforce will be with him…",
                       Preview = "/img/drivers/preview/norris.png",
                       Helmet = "/img/drivers/helmet/norris.png",
                       Img = "/img/drivers/driver/norris.jpg"
                   },
                   new Driver
                   {
                       Name = "Daniel Ricciardo",
                       Country = "Australia",
                       Team = "McLaren",
                       DateOfBirth = "	01/07/1989",
                       Number = 3,
                       Podiums = 32,
                       Races = 215,
                       Points = 11,
                       Position = 11,
                       Championships = 0,
                       Description = "The self-styled “Honey Badger” is fuzzy on the outside and feisty on the inside. Drivers beware because behind Ricciardo’s laidback persona and big grin is a razor-sharp racer with a bite.  \n" +
                           "The Australian combines all-out speed with impressive race craft. Never afraid to push to the limits if it means pulling off a pass, Ricciardo is a proven race-winner, capable of consistently finishing at the business end of the championship table given the right machinery. \n" +
                           "A regular podium-finisher in his days with Red Bull, Ricciardo has christened the steps around the world with a dousing of Aussie culture – the ‘Shoey’ – as he quaffed champagne from a soggy racing boot. Yes it’s goofy, but the trademark celebration illustrates why he is loved for his sense of humour but never underestimated on track.  \n " +
                           "His career’s next move to Renault’s works team in 2019 brought fresh challenges for the Perth pilot, but failed to deliver his dream of following Jack Brabham and Alan Jones as the next world champion from Down Under and he moved on to McLaren for 2021. \n" +
                           "There he has found a tough young team mate in Lando Norris, but has nevertheless returned to winning ways. Whatever happens next, Ricciardo is sure to keep on smiling.",
                       Preview = "/img/drivers/preview/ricciardo.png",
                       Helmet = "/img/drivers/helmet/ricciardo.png",
                       Img = "/img/drivers/driver/ricciardo.jpg"
                   },
                   new Driver
                   {
                       Name = "Valtteri Bottas",
                       Country = "Finland",
                       Team = "Alfa Romeo",
                       DateOfBirth = "28/08/1989",
                       Number = 77,
                       Podiums = 67,
                       Races = 183,
                       Points = 30,
                       Position = 8,
                       Championships = 0,
                       Description = "Learning his craft on Finnish roads of ice and snow, he was born to be a Grand Prix racer. \n" +
                           "Bottas explains that if you can drive on the frozen roads of his homeland then you can drive anywhere. Then there’s the Finnish mentality –reserved, diligent and calm the fast lane of F1 doesn’t faze him. \n" +
                           "Making his F1 debut with Williams in 2013, Bottas soon became part of the family. Points and podiums followed with the reliable racer even amassing the most points without a win, a record he resented but that showcased his ability. The fact the Finn was such a points machine saw him suddenly promoted to the most coveted seat in F1 - Nico Rosberg’s vacant championship-winning seat at Mercedes. \n " +
                           "Bottas blossomed at the Silver Arrows in 2017, unleashing his pace to clock up personal pole positions and victories as well as a team championship for the famous Mercedes marque alongside Lewis Hamilton. He even tied with Hamilton and Sebastian Vettel with 13 podiums. \n" +
                           "For 2022 he starts a new chapter in his F1 career, replacing compatriot Kimi Raikkonen to lead an all-new line-up at Alfa Romeo, where he is charged with taking Chinese rookie Zhou Guanyu under his wing.",
                       Preview = "/img/drivers/preview/bottas.png",
                       Helmet = "/img/drivers/helmet/bottas.png",
                       Img = "/img/drivers/driver/bottas.jpg"
                   },
                   new Driver
                   {
                       Name = "Zhou Guanyu",
                       Country = "China",
                       Team = "Alfa Romeo",
                       DateOfBirth = "30/05/1999",
                       Number = 24,
                       Podiums = 0,
                       Races = 5,
                       Points = 1,
                       Position = 18,
                       Championships = 0,
                       Description = "China has never boasted a Grand Prix starter among its citizens – but Zhou Guanyu is the driver charged with changing that state of affairs, after receiving the call-up to make his F1 debut for Alfa Romeo in 2022.  \n" +
                           "The Shanghai-born racer attended his home city’s inaugural Grand Prix in 2004 at the age of five, cheering on his hero Fernando Alonso. But having caught the racing bug, the Chinese driver then set himself the ambitious goal of becoming his country’s first-ever F1 racer – achieving a feat that Ma Qinghua, the only other Chinese driver to take part in a Formula 1 weekend, never managed. \n" +
                           "Showing boldness and dedication, Zhou put his plan into action by moving to England with his family aged just 12 to pursue his motorsport ambitions. A second-place finish in the 2015 Italian F4 championship proved Zhou was possessed of the right stuff – a fact already noted by Ferrari, who’d signed him to their driver academy a year earlier. \n " +
                           "A move to Renault’s academy for 2019 coincided with his debut in Formula 2, with Zhou building his confidence in the series via multiple wins and pole positions across three seasons, leading to him challenging for the drivers’ title in 2021.  \n" +
                           "That was enough to convince Alfa Romeo Team Principal Fred Vasseur to put his faith in Zhou for 2022 and field him alongside ex-Mercedes racer Valtteri Bottas – allowing Zhou to achieve his dream of racing in F1, and even to see how he fares against his own childhood hero, Fernando Alonso.",
                       Preview = "/img/drivers/preview/zhou.png",
                       Helmet = "/img/drivers/helmet/zhou.png",
                       Img = "/img/drivers/driver/zhou.jpg"
                   },
                   new Driver
                   {
                       Name = "Esteban Ocon",
                       Country = "France",
                       Team = "Alpine",
                       DateOfBirth = "17/09/1996",
                       Number = 31,
                       Podiums = 2,
                       Races = 94,
                       Points = 24,
                       Position = 9,
                       Championships = 0,
                       Description = "If there’s one word that dominates Esteban Ocon’s career, it’s ‘sacrifice’. \n" +
                           "Back when he was just a promising karter, Ocon’s parents sold their house, put their jobs on hold, and began a life on the road, living in a caravan and travelling from circuit to circuit to support their son’s burgeoning career. \n" +
                           "Sacrifice, see – but it worked. 2014 saw Ocon break through in the world of single-seaters, as he beat a certain Max Verstappen to the European F3 title. Backed by Mercedes, he won the GP3 title the following year and was halfway through a season of DTM in 2016 when he was offered the chance to replace Rio Haryanto at the minnow Manor team from the Belgian Grand Prix onwards. \n " +
                           "That opportunity led to a full-time seat the following year with Force India, where his wheel-to-wheel duels with highly-rated team mate Sergio Perez quickly marked him out as a rising star. But when Lawrence Stroll, father of racer Lance, stepped in midway through 2018 to secure the squad’s financial future, the writing was on the wall for Ocon, who was moved aside at the end of the year to allow Stroll Jnr to join from Williams. \n" +
                           "Ocon bided his time, though, and after a year on the sidelines as Mercedes’ reserve driver, he found his way back into a race seat for 2020 with Renault, who became Alpine for 2021 – when his wait finally paid off, as he scored his – and the famous French marque’s – first F1 win.",
                       Preview = "/img/drivers/preview/ocon.png",
                       Helmet = "/img/drivers/helmet/ocon.png",
                       Img = "/img/drivers/driver/ocon.jpg"
                   },
                   new Driver
                   {
                       Name = "Fernando Alonso",
                       Country = "Spain",
                       Team = "Alpine",
                       DateOfBirth = "01/09/1994",
                       Number = 14,
                       Podiums = 98,
                       Races = 341,
                       Points = 2,
                       Position = 16,
                       Championships = 2,
                       Description = "Michael Schumacher was the undisputed king of Formula 1 in the early 2000s, picking up wins and championships at a rate that was simply unheard of at the time. It was going to take someone very special to topple the Ferrari legend from his throne – and that it was Fernando Alonso who did it, tells you all you need to know about the Spaniard. \n" +
                           "Fiercely competitive, Alonso is not shy about his talent, rating himself as 9/10 “in everything”, and few in the know would disagree, with his performances in F1 characterised by blistering speed, brilliant tactical thinking, exemplary race craft, a razor-sharp eye for detail and a relentless determination to win. \n" +
                           "A serial record breaker in his early days, he was – at one time – F1’s youngest polesitter, race winner, world champion and double world champion as he gobbled up success with the Renault team. Even Alonso couldn’t continue that amazing run in his later career though, failing to add another title to his collection despite spells at McLaren and Ferrari. \n " +
                           "But after two years away from Formula 1 racing – and with two Le Mans wins in his pocket – Alonso returned with Alpine in 2021. And he has unfinished business with F1…",
                       Preview = "/img/drivers/preview/alonso.png",
                       Helmet = "/img/drivers/helmet/alonso.png",
                       Img = "/img/drivers/driver/alonso.jpg"
                   },
                   new Driver
                   {
                       Name = "Yuki Tsunoda",
                       Country = "Japan",
                       Team = "AlphaTauri",
                       DateOfBirth = "11/05/2000",
                       Number = 22,
                       Podiums = 0,
                       Races = 27,
                       Points = 10,
                       Position = 12,
                       Championships = 0,
                       Description = "In the entire history of Formula 1, no Japanese driver has ever won a World Championship Grand Prix. Could Yuki Tsunoda be the first? Red Bull certainly think so, with the youngster very much on the path to their senior team if he continues to impress as he has done over the past few years. \n" +
                           "Tsunoda's ascent to the top tier of motorsport was astonishingly rapid: he went from racing in Japanese F4 to a Formula 1 seat with AlphaTauri in just over three years, having arrived in Europe in 2019 with no knowledge of the circuits. \n" +
                           "But after a slow start in F3, followed by a hugely impressive debut F2 campaign that saw him finish third in the championship and pick up three wins along the way, Tsunoda proved he had the speed and the race craft to force his way on to the F1 grid. \n " +
                           "He may not have adapted to Grand Prix racing quite as quickly as he did to F2, but given time he could yet find himself battling at the very sharp end in a Red Bull.",
                       Preview = "/img/drivers/preview/tsunoda.png",
                       Helmet = "/img/drivers/helmet/tsunoda.png",
                       Img = "/img/drivers/driver/tsunoda.jpg"
                   },
                   new Driver
                   {
                       Name = "Pierre Gasly",
                       Country = "France",
                       Team = "AlphaTauri",
                       DateOfBirth = "	07/02/1996",
                       Number = 10,
                       Podiums = 3,
                       Races = 91,
                       Points = 6,
                       Position = 13,
                       Championships = 0,
                       Description = "If there’s one man who knows how big a rollercoaster ride an F1 driver’s career can be, it’s Pierre Gasly! \n" +
                           "The flying Frenchman was called up to make his 2017 debut in Malaysia in place of Daniil Kvyat and, after proving his mettle, he was named a Toro Rosso driver the following year.  A further 21 races into his fledgling career, Gasly was moved up again – this time to replace Red Bull big gun Daniel Ricciardo. \n" +
                           "Gasly seemed to have a knack of being in the right place at the right time – a quality that’s equally handy on track. A series of impressive 2018 performances for Toro Rosso – including a brilliant fourth place in Bahrain – showed exciting promise for what he might do with the ‘A’ team in 2019. \n " +
                           "Unfortunately that promise only appeared in flashes – and he quickly suffered from unfavourable comparisons with superstar team mate Max Verstappen. So much so that after the summer break, he was sent back to Toro Rosso, with another young up-and-comer – Alex Albon – being given a shot in the ‘senior’ Red Bull seat. \n" +
                           "But Gasly bounced back, as only Gasly can. In the season’s remaining nine races he scored almost as many points as team mate Kvyat managed over the entire year – and secured his best-ever race result with P2 in Brazil. That trajectory continued in 2020, peaking with an emotional maiden win at the renamed AlphaTauri team’s home race in Italy, and didn’t let up in 2021 when he was back on the podium and scored 110 of the squad’s 142 points.",
                       Preview = "/img/drivers/preview/gasly.png",
                       Helmet = "/img/drivers/helmet/gasly.png",
                       Img = "/img/drivers/driver/gasly.jpg"
                   },
                   new Driver
                   {
                       Name = "Kevin Magnussen",
                       Country = "Denmark",
                       Team = "Haas",
                       DateOfBirth = "05/10/1992",
                       Number = 20,
                       Podiums = 1,
                       Races = 125,
                       Points = 15,
                       Position = 10,
                       Championships = 0,
                       Description = "Call him a lone ranger or a maverick, but Magnussen is back in Formula 1 for one reason only – to race. \n" +
                           "He may be a second-generation F1 driver – following his father, Jan, onto the grid – but Magnussen’s idols are from the ‘golden era’ of Grand Prix racing when the likes of Juan Manuel Fangio and Stirling Moss risked it all for the love of the sport. \n" +
                           "The Roskilde racer’s own prowess was proven on debut for McLaren, who guided him through the junior ranks, when he cruised into the top-three at the 2014 Australian Grand Prix, becoming the first Dane to claim a podium in F1. \n " +
                           "Other champagne moments have been more difficult to find, as he left McLaren behind for a season with Renault, before settling in for four among kindred spirits at Haas. And now he’s back with the US team – after a year away in the States, racing Indy and sportscars among other things. \n" +
                           "His meaty manoeuvres and elbows-out approach have earned him a bad-boy reputation on track, something that still leaves him baffled. Out of the car Magnussen is laidback and affable. After all he has his dream job – and he is only here to race.",
                       Preview = "/img/drivers/preview/magnussen.png",
                       Helmet = "/img/drivers/helmet/magnussen.png",
                       Img = "/img/drivers/driver/magnussen.jpg"
                   },
                   new Driver
                   {
                       Name = "Mick Schumacher",
                       Country = "Germany",
                       Team = "Haas",
                       DateOfBirth = "22/03/1999",
                       Number = 47,
                       Podiums = 0,
                       Races = 26,
                       Points = 0,
                       Position = 19,
                       Championships = 0,
                       Description = "Plenty of sons of former F1 drivers have joined the sport over the years – two have even emulated their fathers to become world champions – but carrying the Schumacher name is surely an extra level of pressure for Mick, given his father Michael’s extraordinary achievements in Formula 1. \n" +
                           "But Schumacher Junior, a member of the Ferrari Driver Academy, arrived in F1 in 2021 with Haas after clinching the previous season’s F2 title in 2020, to add to the F3 championship he won in 2018 – so there was zero suggestion he had been elevated to the top level of motorsport because of his name.  \n" +
                           "It’s talent that brought him this far and he showed more of the same as he acclimatised to F1 in a tough rookie season, consistently outclassing his team mate in their uncompetitive machinery. \n " +
                           "Now Schumacher must continue to impress if he is to one day follow in his father’s footsteps and claim a race seat with the Scuderia.",
                       Preview = "/img/drivers/preview/schumacher.png",
                       Helmet = "/img/drivers/helmet/schumacher.png",
                       Img = "/img/drivers/driver/schumacher.jpg"
                   },
                   new Driver
                   {
                       Name = "Sebastian Vettel",
                       Country = "Germany",
                       Team = "Aston Martin",
                       DateOfBirth = "03/07/1987",
                       Number = 5,
                       Podiums = 122,
                       Races = 283,
                       Points = 4,
                       Position = 14,
                       Championships = 4,
                       Description = "Born and raised a Bull, then a Prancing Horse, and now the face of Aston Martin’s Formula 1 revival, F1's poster boy of early achievement had won more than all but two drivers in history by the time he was just 26, including back-to-back world titles between 2010 and 2013. \n" +
                           "Vettel’s trademark is pure pace – and of course his one-finger victory salute. In the chase to the chequered flag, he likes to lead from the front and just like his hero, Michael Schumacher. But for all his competitive streak, Vettel has a playful side too and has been known to let loose with a spot of Beatles karaoke - and baby can he drive a car. \n" +
                           "Alongside his four world crowns he can boast more than 50 pole positions and race victories, ranking him – statistically - above many of the biggest names in F1 history. No wonder then that he has twice been hand-picked to return some of Grand Prix oldest names to glory. \n " +
                           "Following his move to Maranello, that mission didn’t exactly go to plan as Vettel’s rivalry with Lewis Hamilton intensified. Then came an additional thorn in his side – young-gun Ferrari team mate Charles Leclerc, the first man to outscore him over a season at the Scuderia. \n" +
                           "His latest challenge is as Aston Martin’s team leader. He has already put them on the podium, but Vettel will need to call on all his speed and experience if he’s to regularly reassert himself over his rivals – and re-establish his reputation as one of the sport’s all-time greats.",
                       Preview = "/img/drivers/preview/vettel.png",
                       Helmet = "/img/drivers/helmet/vettel.png",
                       Img = "/img/drivers/driver/vettel.jpg"
                   },
                   new Driver
                   {
                       Name = "Lance Stroll",
                       Country = "Canada",
                       Team = "Aston Martin",
                       DateOfBirth = "29/10/1998",
                       Number = 18,
                       Podiums = 3,
                       Races = 105,
                       Points = 2,
                       Position = 17,
                       Championships = 0,
                       Description = "There is no such thing as too much too soon for Stroll, a teenage sensation with a wet weather predilection. One of the cool kids on the grid, Stroll was unveiled shortly after his 18th birthday by Williams – before he finished high school and got his road licence.  \n" +
                           "Stroll meant business in his debut 2017 season, setting records on the way. An opportunistic racer he bounded onto the podium in Baku, the youngest rookie to do so. As the son of a wealthy entrepreneur, Stroll is used to a champagne lifestyle but now he knows the fizz tastes all the sweeter on the rostrum. Then in Monza he mastered the downpours to become the youngest driver in history to line up on the front row. \n" +
                           "A single-minded starter, the Canadian loves to make up places on the opening lap and fight through to the points. Stroll has the potential to be a long-term fixture in Formula 1 – as amply illustrated by a maiden pole and another two podiums in 2020. \n " +
                           "Those came after his father Lawrence led the consortium that took over Force India midway through the 2018 season, and then transformed it from Racing Point to Aston Martin for 2021. The future looks bright for both the team and their young driver – and even if it rains then Stroll can keep on motoring at the sharp end of the pack.",
                       Preview = "/img/drivers/preview/stroll.png",
                       Helmet = "/img/drivers/helmet/stroll.png",
                       Img = "/img/drivers/driver/stroll.jpg"
                   },
                   new Driver
                   {
                       Name = "Alexander Albon",
                       Country = "Thailand",
                       Team = "Williams",
                       DateOfBirth = "23/03/1996",
                       Number = 23,
                       Podiums = 2,
                       Races = 43,
                       Points = 3,
                       Position = 15,
                       Championships = 0,
                       Description = "Born in London but racing under the flag of Thailand, Alexander Albon’s first word was in fact Italian. That word was Ferrari – though it was with another Italian team that he got his big F1 break. \n" +
                           "Idolising Michael Schumacher and dreaming of one day racing in Formula 1, the junior Albon was pipped to the 2016 GP3 title by a certain Charles Leclerc. He then left his great friendship with George Russell trackside as he took the 2018 Formula 2 title fight down to the wire. \n" +
                           "Graduating to the F1 big league along with yet another contemporary – Lando Norris – in 2019, Albon did his talking on track with Toro Rosso in the opening races, earning a mid-season promotion to Red Bull Racing. \n " +
                           "A stylish over-taker with a championship mentality, Albon was unfazed by partnering Max Verstappen for the second half of his rookie season, taking top-six finishes in eight of his nine 2019 races with Red Bull. \n" +
                           "Staying in touch with the future champion proved tougher in 2020 and Red Bull dropped him from their race line-up. Crucially, though, Albon was retained as test and reserve driver, keeping him very much on team bosses’ radar, leading to his 2022 return to the grid with Williams.",
                       Preview = "/img/drivers/preview/albon.png",
                       Helmet = "/img/drivers/helmet/albon.png",
                       Img = "/img/drivers/driver/albon.jpg"
                   },
                   new Driver
                   {
                       Name = "Nicholas Latifi",
                       Country = "Canada",
                       Team = "Williams",
                       DateOfBirth = "29/06/1995",
                       Number = 6,
                       Podiums = 0,
                       Races = 44,
                       Points = 0,
                       Position = 20,
                       Championships = 0,
                       Description = "Thirteen is an advanced age to begin your karting career these days. But that’s how old Toronto native Nicholas Latifi was when he took his first steps in motorsport. Just 11 years later, he became a fully-fledged Formula 1 driver. \n" +
                           "That ascension into racing's top category was largely thanks to his most impressive season to date in Formula 2 in 2019, with Latifi – who’d finished a disappointing ninth in the series’ 2018 standings – pulling up his bootstraps to claim second in the championship. That result, combined with the Williams/Robert Kubica union failing to mesh in 2019, meant Williams made the call to promote their affable Canadian reserve driver to a full-time drive alongside George Russell for 2020. \n" +
                           "Latifi’s first taste of F1 machinery actually came all the way back in 2017, when he was given a test by Renault. Further duties with Force India followed in 2018 before he joined the Williams family in 2019. It was an annus horribilis for the squad, no doubt – but Latifi’s straightforward, friendly attitude and insightful feedback helped swing the vote in his favour for 2020. \n " +
                           "Now, after two seasons living in Russell’s shadow – and with Williams' form on the rise and a new team mate in the shape of ex-Red Bull racer Alex Albon – the goal is to show that that his eye-catching F2 year wasn’t just a fluke, and finally prove that he really has got what it takes to mix it with the best drivers in the world.",
                       Preview = "/img/drivers/preview/latifi.png",
                       Helmet = "/img/drivers/helmet/latifi.png",
                       Img = "/img/drivers/driver/latifi.jpg"
                   });

            if (!context.RaceResult.Any())
                context.RaceResult.AddRange(
                    new RaceResult
                    {
                        Name = "Bahrain",
                        Date = "20 Mar 2022",
                        Winner = "Charles Leclerc",
                        Team = "Ferrari",
                        Laps = 57,
                        Time = "1:37:33.584"
                    },
                    new RaceResult
                    {
                        Name = "Saudi Arabia",
                        Date = "27 Mar 2022",
                        Winner = "Max Verstappen",
                        Team = "Red Bull",
                        Laps = 50,
                        Time = "1:24:19.293"
                    },
                    new RaceResult
                    {
                        Name = "Australia",
                        Date = "10 Apr 2022",
                        Winner = "Charles Leclerc",
                        Team = "Ferrari",
                        Laps = 58,
                        Time = "1:27:46.548"
                    },
                    new RaceResult
                    {
                        Name = "Emilia Romagna",
                        Date = "24 Apr 2022",
                        Winner = "Max Verstappen",
                        Team = "Red Bull",
                        Laps = 63,
                        Time = "1:32:07.986"
                    },
                    new RaceResult
                    {
                        Name = "Miami",
                        Date = "08 May 2022",
                        Winner = "Max Verstappen",
                        Team = "Red Bull",
                        Laps = 57,
                        Time = "1:34:24.258"
                    });

            if (!context.Race.Any())
                context.Race.AddRange(
                    new Race
                    {
                        Name = "Bahrain",
                        Date = "18-20 Mar",
                        Round = 1,
                        RaceDate = "20 Mar",
                        QualiDate = "19 Mar",
                        P1Date = "18 Mar",
                        P2Date = "18 Mar",
                        P3Date = "19 Mar",
                        IsFinished = true,
                        Place1 = "Charles LECLERC",
                        Place2 = "Carlos SAINZ",
                        Place3 = "Lewis HAMILTON",
                        Img = "/img/races/bah.png"
                    },
                    new Race
                    {
                        Name = "Australia",
                        Date = "08-10 Apr",
                        Round = 2,
                        RaceDate = "10 Apr",
                        QualiDate = "09 Apr",
                        P1Date = "08 Apr",
                        P2Date = "08 Apr",
                        P3Date = "09 Apr",
                        IsFinished = true,
                        Place1 = "Charles LECLERC",
                        Place2 = "Sergio PEREZ",
                        Place3 = "George RUSSELL",
                        Img = "/img/races/aus.png"
                    },
                    new Race
                    {
                        Name = "Monaco",
                        Date = "27-29 May",
                        Round = 3,
                        RaceDate = "29 May",
                        QualiDate = "28 May",
                        P1Date = "27 May",
                        P2Date = "27 May",
                        P3Date = "28 May",
                        IsFinished = false,
                        Place1 = "",
                        Place2 = "",
                        Place3 = "",
                        Img = "/img/races/mon.png"
                    },
                    new Race
                    {
                        Name = "Azerbaijan",
                        Date = "10-12 Jun",
                        Round = 4,
                        RaceDate = "12 Jun",
                        QualiDate = "11 Jun",
                        P1Date = "10 Jun",
                        P2Date = "10 Jun",
                        P3Date = "11 Jun",
                        IsFinished = false,
                        Place1 = "",
                        Place2 = "",
                        Place3 = "",
                        Img = "/img/races/az.png"
                    });

            if (!context.New.Any())
                context.New.AddRange(
                    new New
                    {
                        Name = "What the teams said – Race day in Spain",
                        Block1= "“It’s great to finish the race today alongside Checo with a first and second place, it was a difficult beginning but a good end! I went off in turn four, I completely lost the rear and they said on Team radio that it was a big gust of wind. I lost a few positions through that and as soon as I wanted to attack, my DRS stopped working. It was upsetting at the time but then I calmed myself down and focussed on the bigger picture. It was a tough battle with George Russell, especially without the DRS, I didn’t want to take too much of a risk as we were fighting for the lead, I had to be patient. As for the DRS, I’m not sure why there’s an issue, we’ll look into it and at the end of the day nothing was lost. We are on a good trajectory and we can be proud of that as a Team, but as you can see, some things are fragile and we need to keep on working hard, we have to be on top of everything.”",
                        Block2 = "“It’s a great result, we are leading the Constructors Championship so, although I obviously want to win, I have to be realistic and I am happy with the Team result. My frustration on the radio was in the heat of the moment but I need to speak with the Team to understand a few bits from the race. Sometimes when you are driving you can’t get the full picture, so it is a normal thing to debrief things to understand the race. The Team momentum couldn’t be any better here, it is a great Team and we are very united. It wasn’t about Team orders today, what really changed my race was going onto different tyre strategies and that worked better for Max and, at the end of the day, the Team because we managed to both get past George. I could have won today but making the two-stop work was difficult and it turned out that the three-stop was the better strategy. I think we had a very strong race today, the race pace and management from us was great today and it was important not to make mistakes. Hopefully we continue this momentum on to Monaco and are strong next weekend too.”",
                        Img = "/img/news/news1.jpg"
                    },
                    new New
                    {
                        Name = "‘This is the start of our season’ says podium finisher Russell after duelling with Verstappen in Spain",
                        Block1 = "Russell briefly led in Spain but was outdone by Verstappen and Sergio Perez as Red Bull secured a one-two – with pole-sitter Charles Leclerc retiring and Carlos Sainz finishing fourth for Ferrari. Given Russell scored his podium in a car donning a significant upgrade package, he was grateful for Mercedes’ hard work.“Yes, I mean, it feels great to be on the podium and I think this showed the hard work and effort that’s gone on at the factory both at Brackley and Brixworth. We’ve always said, you have to be there at the end to pick up the pieces, to pick up the points, especially on days like today.“It was incredibly tough out there for the cars and the drivers. But I feel like we’re making progress and I feel like we, as a team, have turned a page and I feel like this is probably the start of our season now.”",
                        Block2 = "The works driver went on to explain that Mercedes had made a major step in performance having “solved their issue” – perhaps alluding to the bouncing problem that has previously plagued the Silver Arrows this season.“I feel like this was more genuine; I feel like we have probably halved the gap to the frontrunners compared to the rest of the season, and I think we know there’s probably more performance to find.“It’s been a season of problem-solving as opposed to trying to find more performance and bring more performance to the car, and I think we’ve now finally solved our issue and we can now focus on bringing more performance. So, yes, we’re six races behind – but there’s no reason why we can’t claw this back.”As for his long and hard-fought battle with Verstappen, Russell was thrilled to be fighting against the reigning champion and his rapid RB18.",
                        Img = "/img/news/news2.jpg"
                    },
                    new New
                    {
                        Name = "Hamilton left ruing first-lap contact with Magnussen after ‘amazing’ recovery to P5 in Spain",
                        Block1 = "Lewis Hamilton’s run of Spanish Grand Prix victories – stretching back to 2017 – may have come to an end in 2022, but the seven-time champion was still pumped up by his Sunday at the Circuit de Barcelona-Catalunya after he recovered to P5, having been 19th at the end of Lap 1 following contact with Kevin Magnussen.Magnussen was challenging Hamilton around the outside of Turn 4 on Lap 1 of the race when the pair touched, the Haas skipping into the gravel as Hamilton suffered a puncture. Having crawled back to the pits, Hamilton then looked set for a long afternoon after re-joining in P19, at one point imploring his Mercedes team to retire him and save his engine.",
                        Block2 = "“The car felt great in the race; our pace was closer to the rest, the top guys in the race, which was amazing,” said Hamilton. “Just really unfortunate at the start to have got the puncture that we got [in the Magnussen contact]. But I didn’t give up, because that’s what we do.“But jeez, if I hadn’t had that issue at the beginning, who knows where we would have been in the end. But it’s great to know that we had similar pace to some of the frontrunners.”",
                        Img = "/img/news/news3.jpg"
                    },
                    new New
                    {
                        Name = "‘One of the hardest races I’ve ever done’ – Norris diagnosed with tonsillitis after gritty drive to P8 in Spain",
                        Block1 = "Lando Norris was forced to miss the usual post-race media sessions in Barcelona in order to undergo medical checks. It came after a sterling drive to eighth place for McLaren, despite the Briton suffering from tonsillitis.It was no secret that Norris had been unwell throughout the Spanish weekend, and the signs were not good when TV pictures showed him looking rather nauseous at the side of the track ahead of the race start.",
                        Block2 = "Despite that – and the searing heat, with ambient temperatures in the high 30s – Norris climbed into the cockpit and duly took his MCL36 from 11th on the grid to an eventual P8, completing the full 66 laps to finish four places higher than team mate Daniel Ricciardo, who started ninth.“Today was tough,” said Norris. “I was feeling really unwell before the race as I'm suffering with tonsillitis, and that, in combination with the high temperatures, made this one of the hardest races I’ve ever done.",
                        Img = "/img/news/news4.jpg"
                    });


            context.SaveChanges();
        }
    }
}
