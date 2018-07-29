using System;

// Token: 0x0200002E RID: 46
[Serializable]
public class InvStat
{
	// Token: 0x060006B0 RID: 1712 RVA: 0x00051D30 File Offset: 0x0004FF30
	public static int BLBEGJDKOHO(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num -= -66;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Armor)
		{
			num -= -57;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Armor)
		{
			num2 -= 6;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Mana)
		{
			num2 -= -101;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -153;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 174;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += 111;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += -39;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00051DE0 File Offset: 0x0004FFE0
	public static int BFQKNJQDJLO(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num -= 109;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Mana)
		{
			num -= -93;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Strength)
		{
			num2 -= -2;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Strength)
		{
			num2 -= -145;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += 145;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 42;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 45;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += -126;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string QPDGCILDFLP(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00051E90 File Offset: 0x00050090
	public static int GMKNOMMEHKP(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Mana)
		{
			num -= 144;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num -= -116;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num2 -= -103;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Health)
		{
			num2 -= -7;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -69;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += -95;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 104;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num2 += -118;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00051F40 File Offset: 0x00050140
	public static int BKEPHKKCNJC(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= -142;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Strength)
		{
			num -= 146;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Health)
		{
			num2 -= 99;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Crit)
		{
			num2 -= 111;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += 11;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 39;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 83;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num2 += 127;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00051FF0 File Offset: 0x000501F0
	public static int IIICMFJJLQB(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= -9;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= -122;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Armor)
		{
			num2 -= 96;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Strength)
		{
			num2 -= 50;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -5;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 120;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += -90;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num2 += 126;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x000520A0 File Offset: 0x000502A0
	public static int QOJBFPONKFP(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Health)
		{
			num -= 64;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= -86;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num2 -= -130;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Damage)
		{
			num2 -= -159;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += 154;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 26;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 2;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += -31;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string KDIKEFJEMPH(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00052150 File Offset: 0x00050350
	public static int LGEKKKMJGIB(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Strength)
		{
			num -= -68;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= -19;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Agility)
		{
			num2 -= 67;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num2 -= -31;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += 134;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += -139;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 117;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += -91;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string POPOJMOJHKE(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string KFOGJPMOHBQ(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00052200 File Offset: 0x00050400
	public static int LNQPDFBJFKK(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Crit)
		{
			num -= 125;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= 48;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Health)
		{
			num2 -= -134;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num2 -= -116;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += 196;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 106;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 104;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 36;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x000522B0 File Offset: 0x000504B0
	public static int IMCOCJJLLDI(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= -118;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Strength)
		{
			num -= 20;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Damage)
		{
			num2 -= -34;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Agility)
		{
			num2 -= 96;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += -24;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += -170;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 25;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 16;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00052360 File Offset: 0x00050560
	public static int MGGOOFEHOOL(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= 77;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Strength)
		{
			num -= -198;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Mana)
		{
			num2 -= -120;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num2 -= 148;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += -59;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += -63;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 76;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 16;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string DDCMFLFDHJH(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00052410 File Offset: 0x00050610
	public static int QMQKOJEPHFP(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Armor)
		{
			num -= 115;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Crit)
		{
			num -= 155;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num2 -= -42;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Health)
		{
			num2 -= -92;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += 104;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 3;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += 36;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 11;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string HPMKCBQDMKG(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x000524C0 File Offset: 0x000506C0
	public static int OCDFBQNJNDL(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Strength)
		{
			num -= -66;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= 114;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Agility)
		{
			num2 -= -86;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num2 -= 174;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += 8;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 111;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 72;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 118;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00052570 File Offset: 0x00050770
	public static int KPIQBGEINJI(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Mana)
		{
			num -= -197;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Health)
		{
			num -= -45;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num2 -= -32;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Strength)
		{
			num2 -= 15;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -80;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += -139;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += 126;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += -120;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00052620 File Offset: 0x00050820
	public static int KOCEOFQHPLH(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Agility)
		{
			num -= -131;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Agility)
		{
			num -= 166;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Armor)
		{
			num2 -= -174;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Mana)
		{
			num2 -= -138;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -56;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 122;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += -48;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += -77;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string LNJBLLPOCIQ(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x000526D0 File Offset: 0x000508D0
	public static string OGLHBLJFPIG(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		switch (OMBOCJEKDFF)
		{
		case InvStat.PICFGJDOMQI.Strength:
			return "Strength increases melee damage";
		case InvStat.PICFGJDOMQI.Constitution:
			return "Constitution increases health";
		case InvStat.PICFGJDOMQI.Agility:
			return "Agility increases armor";
		case InvStat.PICFGJDOMQI.Intelligence:
			return "Intelligence increases mana";
		case InvStat.PICFGJDOMQI.Damage:
			return "Damage adds to the amount of damage done in combat";
		case InvStat.PICFGJDOMQI.Crit:
			return "Crit increases the chance of landing a critical strike";
		case InvStat.PICFGJDOMQI.Armor:
			return "Armor protects from damage";
		case InvStat.PICFGJDOMQI.Health:
			return "Health prolongs life";
		case InvStat.PICFGJDOMQI.Mana:
			return "Mana increases the number of spells that can be cast";
		default:
			return null;
		}
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00052740 File Offset: 0x00050940
	public static int FFBKCJJOODQ(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Armor)
		{
			num -= -187;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Crit)
		{
			num -= -72;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Crit)
		{
			num2 -= 30;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Crit)
		{
			num2 -= -54;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -137;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += 107;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += -6;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 114;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string KNIGFKBFIOH(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x000527F0 File Offset: 0x000509F0
	public static int BMKEFOGMOOC(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num -= 58;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Armor)
		{
			num -= 46;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Crit)
		{
			num2 -= 90;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Crit)
		{
			num2 -= 93;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -97;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 3;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += -37;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num2 += 17;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x000528A0 File Offset: 0x00050AA0
	public static int MGGFHJNGNEL(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Armor)
		{
			num -= 10000;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= 5000;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Armor)
		{
			num2 -= 10000;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Damage)
		{
			num2 -= 5000;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += 1000;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 1000;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += 100;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 100;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00052950 File Offset: 0x00050B50
	public static int IIONMBGFIBE(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Crit)
		{
			num -= -91;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num -= 44;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Health)
		{
			num2 -= 63;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Crit)
		{
			num2 -= 120;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -178;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += -42;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += 12;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 63;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00052A00 File Offset: 0x00050C00
	public static int FQOLNIHKJOO(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= 10000;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Armor)
		{
			num -= 5000;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Damage)
		{
			num2 -= 10000;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Armor)
		{
			num2 -= 5000;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += 1000;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 1000;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += 100;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 100;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00052AB0 File Offset: 0x00050CB0
	public static int IELDKBCPBFC(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= 57;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= -132;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Armor)
		{
			num2 -= 16;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Strength)
		{
			num2 -= -98;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += 58;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2++;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += -90;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num2 += -17;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string BBJKOKBBECI(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string LDJBJIMQQDM(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00052B60 File Offset: 0x00050D60
	public static int QCMCPQCIMHK(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= -125;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= 38;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Constitution)
		{
			num2 -= 123;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Armor)
		{
			num2 -= -145;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += -173;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 109;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += -128;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num2 += -63;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00052C10 File Offset: 0x00050E10
	public static int QOMDCQCLLPD(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= -151;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Mana)
		{
			num -= 52;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Agility)
		{
			num2 -= -140;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Agility)
		{
			num2 -= -111;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += 88;
		}
		if (IBMINEHKPFF.amount < 1)
		{
			num2 += -151;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += 91;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num2 += -36;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string NOEEGLGJICD(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00052CC0 File Offset: 0x00050EC0
	public static string HQOKQIODJHC(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		switch (OMBOCJEKDFF)
		{
		case InvStat.PICFGJDOMQI.Strength:
			return "Ultra Ball";
		case InvStat.PICFGJDOMQI.Constitution:
			return "3";
		case InvStat.PICFGJDOMQI.Agility:
			return "[ATK]";
		case InvStat.PICFGJDOMQI.Intelligence:
			return "Shake Influence";
		case InvStat.PICFGJDOMQI.Damage:
			return "'s [ffff00]";
		case InvStat.PICFGJDOMQI.Crit:
			return "Materials/DFGDesktopPlus";
		case InvStat.PICFGJDOMQI.Armor:
			return "Teleport Cooldown";
		case InvStat.PICFGJDOMQI.Health:
			return "Reckless";
		case InvStat.PICFGJDOMQI.Mana:
			return " is an Ephemeral Port which is used by TCP/UDP as Source/Outgoing port. This may cause problems!";
		default:
			return null;
		}
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00052D30 File Offset: 0x00050F30
	public static string GPKHNGGDQPN(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		switch (OMBOCJEKDFF)
		{
		case InvStat.PICFGJDOMQI.Strength:
			return "_ChromaticAberration_Spectrum";
		case InvStat.PICFGJDOMQI.Constitution:
			return " became confused!\r\n";
		case InvStat.PICFGJDOMQI.Agility:
			return "[33CCFF]";
		case InvStat.PICFGJDOMQI.Intelligence:
			return "Mineral Badge";
		case InvStat.PICFGJDOMQI.Damage:
			return "item: ";
		case InvStat.PICFGJDOMQI.Crit:
			return "AlwaysSnow";
		case InvStat.PICFGJDOMQI.Armor:
			return "\nEvening";
		case InvStat.PICFGJDOMQI.Health:
			return " began having a nightmare!\r\n";
		case InvStat.PICFGJDOMQI.Mana:
			return "End";
		default:
			return null;
		}
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00052DA0 File Offset: 0x00050FA0
	public static int JJGJNIMPIOJ(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Damage)
		{
			num -= -70;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Health)
		{
			num -= -126;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Health)
		{
			num2 -= 172;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Agility)
		{
			num2 -= -50;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += -177;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 184;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += 44;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 21;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00052E50 File Offset: 0x00051050
	public static string HLOKOGNOCGP(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		switch (OMBOCJEKDFF)
		{
		case InvStat.PICFGJDOMQI.Strength:
			return "#,##0";
		case InvStat.PICFGJDOMQI.Constitution:
			return "_DetailScaleX";
		case InvStat.PICFGJDOMQI.Agility:
			return "airlock";
		case InvStat.PICFGJDOMQI.Intelligence:
			return "item: ";
		case InvStat.PICFGJDOMQI.Damage:
			return "bind";
		case InvStat.PICFGJDOMQI.Crit:
			return "p1";
		case InvStat.PICFGJDOMQI.Armor:
			return "_";
		case InvStat.PICFGJDOMQI.Health:
			return "par";
		case InvStat.PICFGJDOMQI.Mana:
			return "/hiddenlag";
		default:
			return null;
		}
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00052EC0 File Offset: 0x000510C0
	public static int JIHPKEJDJBL(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num -= 47;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Crit)
		{
			num -= -141;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Damage)
		{
			num2 -= -41;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Strength)
		{
			num2 -= -162;
		}
		if (ECHMFPQNBMC.amount < 0)
		{
			num += -70;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += -138;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Added)
		{
			num += -20;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 23;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00004B0A File Offset: 0x00002D0A
	public static string EFHDQBIQBEJ(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.ToString();
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00052F70 File Offset: 0x00051170
	public static string FBKPHLPIGKD(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		switch (OMBOCJEKDFF)
		{
		case InvStat.PICFGJDOMQI.Strength:
			return "map:flymap";
		case InvStat.PICFGJDOMQI.Constitution:
			return "Start";
		case InvStat.PICFGJDOMQI.Agility:
			return "Party";
		case InvStat.PICFGJDOMQI.Intelligence:
			return ")";
		case InvStat.PICFGJDOMQI.Damage:
			return "[/u][/urn][-]: ";
		case InvStat.PICFGJDOMQI.Crit:
			return "[-]";
		case InvStat.PICFGJDOMQI.Armor:
			return "Map";
		case InvStat.PICFGJDOMQI.Health:
			return "[ff6666]";
		case InvStat.PICFGJDOMQI.Mana:
			return "12";
		default:
			return null;
		}
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00052FE0 File Offset: 0x000511E0
	public static int BFJFIOGOGBB(InvStat ECHMFPQNBMC, InvStat IBMINEHKPFF)
	{
		int num = (int)ECHMFPQNBMC.id;
		int num2 = (int)IBMINEHKPFF.id;
		if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Crit)
		{
			num -= 19;
		}
		else if (ECHMFPQNBMC.id == InvStat.PICFGJDOMQI.Strength)
		{
			num -= 55;
		}
		if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Damage)
		{
			num2 -= -39;
		}
		else if (IBMINEHKPFF.id == InvStat.PICFGJDOMQI.Intelligence)
		{
			num2 -= -180;
		}
		if (ECHMFPQNBMC.amount < 1)
		{
			num += -140;
		}
		if (IBMINEHKPFF.amount < 0)
		{
			num2 += 16;
		}
		if (ECHMFPQNBMC.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num += -95;
		}
		if (IBMINEHKPFF.modifier == InvStat.JPLHHNKQLOI.Percent)
		{
			num2 += 34;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00053090 File Offset: 0x00051290
	public static string GFQJGOQEFNK(InvStat.PICFGJDOMQI OMBOCJEKDFF)
	{
		switch (OMBOCJEKDFF)
		{
		case InvStat.PICFGJDOMQI.Strength:
			return "Boosts the Defense stat when hit by an attack.";
		case InvStat.PICFGJDOMQI.Constitution:
			return "[00EE07]";
		case InvStat.PICFGJDOMQI.Agility:
			return "Expected to have 'target' set to a valid transform";
		case InvStat.PICFGJDOMQI.Intelligence:
			return "VFMDepthCamera";
		case InvStat.PICFGJDOMQI.Damage:
			return "Ambient Occlusion";
		case InvStat.PICFGJDOMQI.Crit:
			return "Blaze";
		case InvStat.PICFGJDOMQI.Armor:
			return "Hidden/Post FX/Bloom";
		case InvStat.PICFGJDOMQI.Health:
			return "But it failed!\r\n";
		case InvStat.PICFGJDOMQI.Mana:
			return "_MaxCoC";
		default:
			return null;
		}
	}

	// Token: 0x040000F3 RID: 243
	public InvStat.PICFGJDOMQI id;

	// Token: 0x040000F4 RID: 244
	public InvStat.JPLHHNKQLOI modifier;

	// Token: 0x040000F5 RID: 245
	public int amount;

	// Token: 0x0200002F RID: 47
	public enum PICFGJDOMQI
	{
		// Token: 0x040000F7 RID: 247
		Strength,
		// Token: 0x040000F8 RID: 248
		Constitution,
		// Token: 0x040000F9 RID: 249
		Agility,
		// Token: 0x040000FA RID: 250
		Intelligence,
		// Token: 0x040000FB RID: 251
		Damage,
		// Token: 0x040000FC RID: 252
		Crit,
		// Token: 0x040000FD RID: 253
		Armor,
		// Token: 0x040000FE RID: 254
		Health,
		// Token: 0x040000FF RID: 255
		Mana,
		// Token: 0x04000100 RID: 256
		Other
	}

	// Token: 0x02000030 RID: 48
	public enum JPLHHNKQLOI
	{
		// Token: 0x04000102 RID: 258
		Added,
		// Token: 0x04000103 RID: 259
		Percent
	}
}
