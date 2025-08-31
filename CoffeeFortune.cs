using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyBrew
{

    public class FortuneDate
    {
        public string CoffeeName { get; set; }
        public List<string> Advices { get; set; }
        public Image CoffeeImage { get; set; }
    }

    public class CoffeeFortune
    {
        private Dictionary<string, List<string>> moodToCoffeeMap = new Dictionary<string, List<string>>();
        private Dictionary<string, FortuneDate> coffeeFortunes = new Dictionary<string, FortuneDate>();
        private Random random = new Random();

        public CoffeeFortune()
        {
            random = new Random();
            InitializeData();
        }

        private void InitializeData()
        {
            moodToCoffeeMap["기쁨"] = new List<string> { "에스프레소", "아인슈페너" };
            moodToCoffeeMap["분노"] = new List<string> { "아메리카노", "카페 모카" };
            moodToCoffeeMap["평온"] = new List<string> { "카푸치노", "돌체 라떼" };
            moodToCoffeeMap["슬픔"] = new List<string> { "카라멜 마키아토", "헤이즐넛 라떼" };
            moodToCoffeeMap["피로"] = new List<string> { "아메리카노", "카페 라떼" };
            moodToCoffeeMap["불안"] = new List<string> { "카페 라떼", "아인슈페너" };

            coffeeFortunes["에스프레소"] = new FortuneDate
            {
                CoffeeName = "에스프레소",
                Advices = new List<string> {
                    "오늘 당신의 운세는 에스프레소처럼 짧고 강렬한 만남으로 새로운 기회를 얻게 될 거예요. 순간의 집중이 큰 성과를 가져올 수 있습니다.",
                    "에스프레소는 당신의 내면에 숨겨진 열정을 깨웁니다. 오늘 당신의 직감을 믿고, 과감하게 밀고 나가세요. 당신의 강력한 에너지가 빛을 발할 거예요.",
                    "에스프레소처럼 당신의 하루는 순수한 본질에 집중하게 될 것입니다. 불필요한 것들은 과감히 버리고, 핵심 목표에만 집중하면 의외로 쉽게 해결될 수 있습니다.",
                    "에스프레소의 강한 씁쓸함 뒤에 오는 깊은 향처럼, 오늘 당신은 힘든 상황을 겪을 수 있지만, 그 경험이 당신을 더욱 단단하게 만들 것입니다.",
                    "에스프레소 한 잔처럼, 오늘 당신은 당신의 생각을 명확하고 간결하게 전달해야 합니다. 당신의 솔직함이 사람들의 마음을 움직일 것입니다."
                },
                CoffeeImage = Properties.Resources.espresso
            };

            coffeeFortunes["아메리카노"] = new FortuneDate
            {
                CoffeeName = "아메리카노",
                Advices = new List<string> {
                    "오늘 당신의 운세는 아메리카노처럼 맑고 투명합니다. 중요한 결정을 앞두고 있다면, 복잡하게 생각하지 말고 가장 기본에 충실하세요.",
                    "아메리카노처럼, 오늘 당신은 다양한 사람들과의 만남을 통해 새로운 아이디어를 얻게 될 것입니다. 열린 마음으로 타인의 의견을 경청하는 것이 중요합니다.",
                    "아메리카노는 그 어떤 것과도 잘 어울립니다. 오늘 당신의 하루는 조화롭고 안정적일 것입니다. 일상 속에서 편안함과 즐거움을 찾아보세요.",
                    "아메리카노의 깔끔한 끝맛처럼, 오늘 당신이 마무리하는 일은 깨끗하고 만족스러운 결과를 가져올 것입니다. 서두르지 않고 차근차근 최선을 다하세요.",
                    "아메리카노 한 잔처럼, 조용하고 평화로운 하루가 될 것입니다. 바쁜 일상 속에서 잠시 멈춰 서서 당신 자신을 돌아보는 시간을 가져보세요."
                },
                CoffeeImage = Properties.Resources.americano
            };

            coffeeFortunes["카페 라떼"] = new FortuneDate
            {
                CoffeeName = "카페 라떼",
                Advices = new List<string> {
                    "오늘 당신의 운세는 카페 라떼와 같습니다. 부드러운 우유가 커피의 쓴맛을 감싸 안듯, 당신의 하루는 따뜻한 위로와 도움으로 가득 찰 것입니다.",
                    "카페 라떼처럼, 오늘 당신은 부드러운 태도로 타인과의 관계를 풀어가야 합니다. 강한 주장보다는 이해와 배려가 더 큰 힘을 발휘할 거예요.",
                    "카페 라떼의 따뜻한 온기처럼, 당신의 마음은 오늘 포근하고 따뜻할 것입니다. 당신의 따뜻한 배려가 주변 사람들에게 긍정적인 영향을 미칠 거예요.",
                    "오늘 당신의 운세는 카페 라떼처럼 조화롭고 균형 잡혀 있습니다. 당신의 삶의 리듬을 조절하는 것이 중요합니다. 일과 휴식 사이에서 완벽한 균형을 찾아보세요.",
                    "카페 라떼의 섬세한 라떼 아트처럼, 오늘 당신의 하루는 작은 아름다움으로 가득 찰 것입니다. 일상 속에서 놓치고 있던 작은 행복을 발견하는 시간을 가져보세요."
                },
                CoffeeImage = Properties.Resources.cafelatte
            };

            coffeeFortunes["카라멜 마키아토"] = new FortuneDate
            {
                CoffeeName = "카라멜 마키아토",
                Advices = new List<string> {
                    "오늘 당신의 운세는 카라멜 마키아토와 같습니다. 달콤한 카라멜이 씁쓸한 커피와 어우러지듯, 당신의 삶에 흥미로운 반전이 찾아올 것입니다.",
                    "카라멜 마키아토처럼, 당신의 노력에 대한 달콤한 보상이 따를 것입니다. 그동안 열심히 해왔던 일에서 긍정적인 결과를 얻게 될 수 있어요.",
                    "카라멜 마키아토의 다층적인 맛처럼, 하나의 문제에 대해 다양한 관점으로 생각해보는 것이 좋습니다. 복잡한 상황일수록 깊이 있는 이해를 통해 해결책을 찾을 수 있습니다.",
                    "카라멜 마키아토에 뿌려진 시럽처럼, 오늘 당신의 삶에 예상치 못한 행운이 찾아올 수 있습니다. 우연한 만남이나 제안을 잘 살펴보세요.",
                    "카라멜 마키아토처럼, 오늘 당신은 당신의 매력을 발산할 수 있는 하루입니다. 당신의 특별함이 주변 사람들의 마음을 사로잡을 것입니다."
                },
                CoffeeImage = Properties.Resources.caramelmacchiato
            };

            coffeeFortunes["아인슈페너"] = new FortuneDate
            {
                CoffeeName = "아인슈페너",
                Advices = new List<string> {
                    "오늘 당신의 운세는 아인슈페너와 같습니다. 달콤한 크림 아래 숨겨진 쌉쌀한 커피처럼, 당신의 하루는 겉보기와 다른 깊이를 지니고 있습니다.",
                    "아인슈페너처럼, 당신은 달콤함과 씁쓸함을 동시에 즐길 수 있는 하루를 보내게 될 것입니다. 힘든 일이 있더라도 그 끝에는 분명 달콤한 보상이 기다리고 있을 거예요.",
                    "아인슈페너처럼 특별하고 우아한 하루가 될 것입니다. 당신의 독특한 개성과 감각을 발휘할 수 있는 좋은 기회가 찾아올 것입니다.",
                    "아인슈페너의 크림이 쌉쌀한 커피를 부드럽게 감싸듯, 오늘 당신은 당신의 약점을 강점으로 바꿀 수 있는 방법을 찾게 될 것입니다.",
                    "아인슈페너처럼, 당신의 하루는 감성적이고 풍요로울 것입니다. 예술 작품을 감상하거나, 아름다운 풍경을 찾아가 새로운 영감을 얻어보세요."
                },
                CoffeeImage = Properties.Resources.einspanner
            };

            coffeeFortunes["카푸치노"] = new FortuneDate
            {
                CoffeeName = "카푸치노",
                Advices = new List<string> {
                    "오늘 당신의 운세는 카푸치노와 같습니다. 풍성한 우유 거품처럼, 당신의 삶에 행복과 즐거움이 넘쳐날 것입니다. 기분 좋은 소식이 당신을 기다리고 있을 수 있습니다.",
                    "카푸치노의 부드러운 거품처럼, 당신의 부드러운 태도가 주변 사람들에게 큰 위로를 줄 것입니다. 다정한 말 한마디가 관계를 더욱 따뜻하게 만들 거예요.",
                    "카푸치노를 만드는 과정처럼, 오늘 당신은 당신의 목표를 위해 차근차근 나아가야 합니다. 서두르지 않고 한 단계씩 나아가면 결국 원하는 것을 얻게 될 것입니다.",
                    "카푸치노 위에 뿌려진 시나몬 가루처럼, 오늘 당신의 하루에 작은 즐거움이 더해질 것입니다. 예상치 못한 곳에서 소소한 행복을 발견해 보세요.",
                    "카푸치노처럼, 당신은 오늘 당신의 따뜻한 마음을 주변 사람들에게 표현해야 합니다. 당신의 진심이 그들의 마음을 움직이고, 당신에게 좋은 기운을 되돌려줄 것입니다."
                },
                CoffeeImage = Properties.Resources.cappuccino
            };

            coffeeFortunes["카페 모카"] = new FortuneDate
            {
                CoffeeName = "카페 모카",
                Advices = new List<string> {
                    "오늘 당신의 운세는 카페 모카와 같습니다. 달콤한 초콜릿이 커피와 어우러지듯, 당신의 하루는 달콤한 즐거움으로 가득 찰 것입니다. 당신의 스트레스를 풀어줄 만한 재미있는 활동을 찾아보세요.",
                    "카페 모카처럼, 당신은 예상치 못한 곳에서 행복을 발견하게 될 것입니다. 일상 속에서 놓치고 있던 작은 즐거움을 찾아보세요.",
                    "카페 모카의 풍부한 맛처럼, 오늘 당신의 감성이 풍요로워지는 하루가 될 것입니다. 예술 작품을 감상하거나, 좋아하는 음악을 들으며 마음의 양식을 쌓아보세요.",
                    "카페 모카의 달콤함과 씁쓸함이 공존하듯, 오늘 당신의 하루는 다양한 감정으로 채워질 것입니다. 감정의 흐름을 자연스럽게 받아들이는 것이 중요합니다.",
                    "카페 모카처럼, 오늘 당신은 당신의 매력을 발산할 수 있는 좋은 기회를 만나게 될 것입니다. 자신감을 가지고 당신의 개성을 마음껏 표현해 보세요."
                },
                CoffeeImage = Properties.Resources.cafemocha
            };

            coffeeFortunes["돌체 라떼"] = new FortuneDate
            {
                CoffeeName = "돌체 라떼",
                Advices = new List<string> {
                    "오늘 당신의 운세는 돌체 라떼처럼 부드러운 달콤함으로 가득 찰 것입니다. 예상치 못한 곳에서 작은 행운을 발견하거나, 기분 좋은 칭찬을 들을 수 있어요.",
                    "돌체 라떼의 깊고 크리미한 맛처럼, 오늘 당신은 중요한 관계에서 깊이 있는 대화를 나누게 될 것입니다. 진심을 나누는 시간이 관계를 더욱 풍요롭게 만들어 줄 거예요.",
                    "돌체 라떼의 따뜻한 온기처럼, 당신의 마음은 오늘 포근하고 따뜻할 것입니다. 힘들었던 일이 있더라도 주변의 위로와 도움으로 쉽게 극복할 수 있어요.",
                    "오늘 당신의 하루는 돌체 라떼에 연유를 추가한 것처럼 특별한 달콤함이 더해질 것입니다. 당신이 노력해왔던 일에서 예상보다 더 큰 성과를 얻게 될 수 있습니다.",
                    "돌체 라떼처럼, 당신은 오늘 진정한 휴식과 안정을 찾게 될 것입니다. 복잡한 생각은 내려놓고, 좋아하는 음악을 듣거나 편안하게 앉아 하루를 마무리하세요."
                },
                CoffeeImage = Properties.Resources.dolcelatte
            };

            coffeeFortunes["헤이즐넛 라떼"] = new FortuneDate
            {
                CoffeeName = "헤이즐넛 라떼",
                Advices = new List<string> {
                    "오늘 당신의 운세는 헤이즐넛 라떼처럼 고소하고 달콤한 하루가 될 것입니다. 당신의 재치와 유머가 사람들의 마음을 열어주는 좋은 도구가 될 거예요.",
                    "헤이즐넛 라떼의 독특한 향처럼, 당신의 하루에 특별한 향기가 더해질 것입니다. 새로운 취미를 시작하거나, 평소 가보고 싶었던 곳을 방문해 보세요.",
                    "헤이즐넛 라떼처럼, 오늘 당신은 당신의 개성을 마음껏 발휘할 수 있는 기회를 만나게 될 것입니다. 자신만의 색깔을 보여주면 좋은 평가를 받을 수 있습니다.",
                    "오늘 당신의 운세는 헤이즐넛 라떼의 고소한 풍미와 같습니다. 주변 사람들에게 긍정적인 에너지를 전달하고, 그들과 함께하는 시간을 통해 기쁨을 얻게 될 거예요.",
                    "헤이즐넛 라떼의 부드러움과 달콤함이 조화를 이루듯, 오늘 당신은 어려운 상황에 직면하더라도 부드러운 태도로 접근하면 쉽게 해결책을 찾을 수 있습니다."
                },
                CoffeeImage = Properties.Resources.hazelnutlatte
            };
        }
        public FortuneDate GetFortuneData(string coffeeName)
        {
            if (coffeeFortunes.ContainsKey(coffeeName))
            {
                return coffeeFortunes[coffeeName];
            }
            return null;
        }

        public string GetRecommendedCoffee(string mood)
        {
            if (moodToCoffeeMap.ContainsKey(mood))
            {
                var coffeeList = moodToCoffeeMap[mood];
                int index = random.Next(coffeeList.Count);
                return coffeeList[index];
            }
            return "아메리카노";
        }

    }
}
