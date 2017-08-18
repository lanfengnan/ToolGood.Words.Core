﻿using System;
using System.Linq;

namespace ToolGood.Words.Core.Test
{
	static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ToolGood.Words.Core Test!");

	        Console.WriteLine("1.文本转换");
			//繁体转简体
			Console.WriteLine($"繁体转简体：壹佰贰拾叁億肆仟伍佰陆拾柒萬捌仟玖佰零壹元壹角贰分->{WordsHelper.ToSimplifiedChinese("壹佰贰拾叁億肆仟伍佰陆拾柒萬捌仟玖佰零壹元壹角贰分")}");

			//简体转繁体
			Console.WriteLine($"简体转繁体：壹佰贰拾叁亿肆仟伍佰陆拾柒万捌仟玖佰零壹元壹角贰分->{WordsHelper.ToTraditionalChinese("壹佰贰拾叁亿肆仟伍佰陆拾柒万捌仟玖佰零壹元壹角贰分")}");

			//半角转全角
			Console.WriteLine($"半角转全角：abc123->{WordsHelper.ToSBC("abcABC123")}");

	        //全角转半角
	        Console.WriteLine($"全角转半角：ａｂｃＡＢＣ１２３->{WordsHelper.ToDBC("ａｂｃＡＢＣ１２３")}");

			// 数字转成中文大写
			Console.WriteLine($"数字转成中文大写：12345678901.12->{WordsHelper.ToChineseRMB(12345678901.12)}");

			//汉字转拼音
			Console.WriteLine($"汉字转拼音：我爱中国->{WordsHelper.GetPinYin("我爱中国")}");

			//获取汉字拼音首字母
			Console.WriteLine($"获取汉字拼音首字母：我爱中国->{WordsHelper.GetFirstPinYin("我爱中国")}");

	        //获取多音字全部拼音
	        Console.WriteLine($"获取多音字全部拼音：强->{string.Join(",", WordsHelper.GetAllPinYin('强').ToArray())}");

	        Console.WriteLine("------------------------------------------------");

	        Console.WriteLine("2.拼音模糊搜索");

			Console.WriteLine("原文本：阿根廷,澳大利亚,比利时,玻利维亚,巴西,白俄罗斯,加拿大,智利,中国,哥伦比亚,哥斯达黎加,古巴,捷克斯洛伐克,丹麦,多米尼加共和国,厄瓜多尔,埃及,萨尔瓦多,埃塞俄比亚,法国,希腊,危地马拉,海地,洪都拉斯,印度,伊朗,伊拉克,黎巴嫩,利比里亚,卢森堡,墨西哥,荷兰,新西兰,尼加拉瓜,挪威,巴拿马,巴拉圭,秘鲁,菲律宾,波兰,俄罗斯联邦,沙特阿拉伯,南非,阿拉伯叙利亚共和国,土耳其,乌克兰,大不列颠及北爱尔兰联合王国,美利坚合众国,乌拉圭,委内瑞拉,南斯拉夫,阿富汗,冰岛,瑞典,泰国,巴基斯坦,也门,缅甸,以色列,印度尼西亚,阿尔巴尼亚,澳地利,保加利亚,柬埔寨,芬兰,匈牙利,爱尔兰,意大利,约旦,老挝人民民主共和国,罗马利亚,西班牙,斯里兰卡,阿拉伯利比亚民众国,尼泊尔,葡萄牙,日本,摩洛哥,苏丹,突尼斯,加纳,马来西亚,几内亚,贝宁,布基纳法索,喀麦隆,中非共和国,乍得,刚果,科特迪瓦,塞浦路斯,加蓬,马达加斯加,马里,尼日尔,尼日利亚,塞内加尔,索马里,多哥,刚果民主共和国,毛里塔尼亚,蒙古,塞拉利昂,坦桑尼亚联合共和国,阿尔及利亚,布隆迪,牙买加,卢旺达,特立尼达和多巴哥,乌干达,肯尼亚,科威特,马拉维,马耳他,赞比亚,冈比亚,马尔代夫,新加坡,巴巴多斯,博茨瓦纳,圭亚那,莱索托,民主也门,赤道几内亚,毛里求斯,斯威士兰,斐济,巴林,不丹,阿曼,卡塔尔,阿拉伯联合酋长国,巴哈马,德意志联邦共和国,德意志民主共和国,孟加拉国,格林纳达,几内亚比绍,佛得角,科摩罗,莫桑比克,巴布亚新几内亚,圣多美和普林西比多米尼加,所罗门群岛,苏里南,安哥拉,萨摩亚,塞舌尔,吉布提,越南,圣卢西亚,圣文森特和格林纳丁斯,津巴布韦,安提瓜和巴布达,伯利兹,瓦努阿图,圣基茨和尼维斯,文莱达鲁萨兰国,列支敦士登,纳米比亚,朝鲜民主主义人民共和国,爱沙尼亚,密克罗尼西亚联邦,拉脱维亚,立陶宛,马绍尔群岛,大韩民国,亚美尼亚,阿塞拜疆,波斯尼亚和黑塞哥维那,克罗地亚,格鲁吉亚,哈萨克斯坦,吉尔吉斯,摩尔多瓦,圣马力诺,斯洛文尼亚,塔吉克斯坦,土库曼斯坦,乌兹别克斯坦,安道尔,捷克共和国,厄立特里亚,摩纳哥,斯洛伐克共和国,前南斯拉夫的马其顿共和国,帕劳,基里巴斯共和国,瑙鲁,汤加,图瓦卢,南斯拉夫,瑞士,东帝汶");
	        var text = "阿根廷,澳大利亚,比利时,玻利维亚,巴西,白俄罗斯,加拿大,智利,中国,哥伦比亚,哥斯达黎加,古巴,捷克斯洛伐克,丹麦,多米尼加共和国,厄瓜多尔,埃及,萨尔瓦多,埃塞俄比亚,法国,希腊,危地马拉,海地,洪都拉斯,印度,伊朗,伊拉克,黎巴嫩,利比里亚,卢森堡,墨西哥,荷兰,新西兰,尼加拉瓜,挪威,巴拿马,巴拉圭,秘鲁,菲律宾,波兰,俄罗斯联邦,沙特阿拉伯,南非,阿拉伯叙利亚共和国,土耳其,乌克兰,大不列颠及北爱尔兰联合王国,美利坚合众国,乌拉圭,委内瑞拉,南斯拉夫,阿富汗,冰岛,瑞典,泰国,巴基斯坦,也门,缅甸,以色列,印度尼西亚,阿尔巴尼亚,澳地利,保加利亚,柬埔寨,芬兰,匈牙利,爱尔兰,意大利,约旦,老挝人民民主共和国,罗马利亚,西班牙,斯里兰卡,阿拉伯利比亚民众国,尼泊尔,葡萄牙,日本,摩洛哥,苏丹,突尼斯,加纳,马来西亚,几内亚,贝宁,布基纳法索,喀麦隆,中非共和国,乍得,刚果,科特迪瓦,塞浦路斯,加蓬,马达加斯加,马里,尼日尔,尼日利亚,塞内加尔,索马里,多哥,刚果民主共和国,毛里塔尼亚,蒙古,塞拉利昂,坦桑尼亚联合共和国,阿尔及利亚,布隆迪,牙买加,卢旺达,特立尼达和多巴哥,乌干达,肯尼亚,科威特,马拉维,马耳他,赞比亚,冈比亚,马尔代夫,新加坡,巴巴多斯,博茨瓦纳,圭亚那,莱索托,民主也门,赤道几内亚,毛里求斯,斯威士兰,斐济,巴林,不丹,阿曼,卡塔尔,阿拉伯联合酋长国,巴哈马,德意志联邦共和国,德意志民主共和国,孟加拉国,格林纳达,几内亚比绍,佛得角,科摩罗,莫桑比克,巴布亚新几内亚,圣多美和普林西比多米尼加,所罗门群岛,苏里南,安哥拉,萨摩亚,塞舌尔,吉布提,越南,圣卢西亚,圣文森特和格林纳丁斯,津巴布韦,安提瓜和巴布达,伯利兹,瓦努阿图,圣基茨和尼维斯,文莱达鲁萨兰国,列支敦士登,纳米比亚,朝鲜民主主义人民共和国,爱沙尼亚,密克罗尼西亚联邦,拉脱维亚,立陶宛,马绍尔群岛,大韩民国,亚美尼亚,阿塞拜疆,波斯尼亚和黑塞哥维那,克罗地亚,格鲁吉亚,哈萨克斯坦,吉尔吉斯,摩尔多瓦,圣马力诺,斯洛文尼亚,塔吉克斯坦,土库曼斯坦,乌兹别克斯坦,安道尔,捷克共和国,厄立特里亚,摩纳哥,斯洛伐克共和国,前南斯拉夫的马其顿共和国,帕劳,基里巴斯共和国,瑙鲁,汤加,图瓦卢,南斯拉夫,瑞士,东帝汶";
	        PinYinSearch search = new PinYinSearch();
	        search.SetKeywords(text.Split(',').ToList());
	        Console.WriteLine("");
			Console.WriteLine($"搜索 ad:{string.Join(",", search.SearchTexts("ad", true).ToArray())}");//安道尔,澳大利亚,澳地利
			Console.WriteLine($"搜索 白e:{string.Join(",", search.SearchTexts("白e", true).ToArray())}");//白俄罗斯
			Console.WriteLine($"搜索 baie:{string.Join(",", search.SearchTexts("baie", true).ToArray())}");//白俄罗斯
			Console.WriteLine($"搜索 bai俄:{string.Join(",", search.SearchTexts("bai俄", true).ToArray())}");//白俄罗斯

			Console.ReadKey();
		}
    }
}