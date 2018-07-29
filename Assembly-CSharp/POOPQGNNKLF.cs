using System;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000130 RID: 304
public class POOPQGNNKLF : MonoBehaviour
{
	// Token: 0x06002379 RID: 9081 RVA: 0x000E8BE0 File Offset: 0x000E6DE0
	public void PJJFGOKNQMJ(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC("Down" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "It created a bizarre area in which Pokemon's held items lose their effects!\r\n" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1614f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 1374f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1982f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.JLENFJGDNFN("TradeColliders");
		}
		else
		{
			this.QNBHJIPIDIP.JLENFJGDNFN("[-]");
		}
	}

	// Token: 0x0600237A RID: 9082 RVA: 0x000E8CFC File Offset: 0x000E6EFC
	public void LOIGHBENOJC(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "watersport" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "OnScroll" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1809f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 1349f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 833f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ("[FF8F00]");
		}
		else
		{
			this.QNBHJIPIDIP.DPBGHDMHKNC("CombinersArgsColorOp1");
		}
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x00012FE0 File Offset: 0x000111E0
	private void JLPLPGINIQL()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("-at", 1712f);
		}
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x000E8E18 File Offset: 0x000E7018
	public void KDDMGIJHJNJ(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = false;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x00013005 File Offset: 0x00011205
	private void FOJBEMBDPQI()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("-copyboost", 1516f);
		}
	}

	// Token: 0x0600237F RID: 9087 RVA: 0x000E8E7C File Offset: 0x000E707C
	public void MLGLILEJCGB(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x06002380 RID: 9088 RVA: 0x000E8EE0 File Offset: 0x000E70E0
	public void HOPCFECFINH(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = false;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x06002381 RID: 9089 RVA: 0x000E8F44 File Offset: 0x000E7144
	public void LCCLHQMCGNB(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.PIDLOFMIEFQ = " woke up!\r\n" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + " shader doesn't have a clipped shader version for " + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 427f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 600f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 421f);
		}
		this.EJIPFIHQQQK.BGBMIEJJQKC = bgbmiejjqkc;
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = "_Source";
		}
		else
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = " was badly poisoned";
		}
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x000E9060 File Offset: 0x000E7260
	public void FJIOGCDOEHE(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x0001302A File Offset: 0x0001122A
	private void DQPLIHHGNKM()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("d", 602f);
		}
	}

	// Token: 0x06002384 RID: 9092 RVA: 0x0001304F File Offset: 0x0001124F
	private void DFDIKBGJIPK()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("trader", 379f);
		}
	}

	// Token: 0x06002385 RID: 9093 RVA: 0x00013074 File Offset: 0x00011274
	private void FHPGLDNLOMQ()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke(" has chosen to use a Pokeball.", 1412f);
		}
	}

	// Token: 0x06002386 RID: 9094 RVA: 0x00013099 File Offset: 0x00011299
	private void CCDOMEQLFGJ()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("The Pokémon gradually regains HP in a hailstorm.", 466f);
		}
	}

	// Token: 0x06002387 RID: 9095 RVA: 0x000E90C4 File Offset: 0x000E72C4
	public void MGNOKQPCFBO(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x06002388 RID: 9096 RVA: 0x000130BE File Offset: 0x000112BE
	private void QIPGKGEBBNI()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("'s Drought intensified the sun's rays!", 1475f);
		}
	}

	// Token: 0x06002389 RID: 9097 RVA: 0x000130E3 File Offset: 0x000112E3
	private void IOLLJNQCJIK()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("|win|", 849f);
		}
	}

	// Token: 0x0600238A RID: 9098 RVA: 0x00013108 File Offset: 0x00011308
	private void NQEFIQFNGCK()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("p2", 1833f);
		}
	}

	// Token: 0x0600238B RID: 9099 RVA: 0x000E90C4 File Offset: 0x000E72C4
	public void PPFGPMNGPJJ(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x0600238C RID: 9100 RVA: 0x000E8E7C File Offset: 0x000E707C
	public void LFKBDNFPDGN(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x0600238D RID: 9101 RVA: 0x000E9060 File Offset: 0x000E7260
	public void LGKPMFPHBMD(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x0600238E RID: 9102 RVA: 0x000E9128 File Offset: 0x000E7328
	public void LBIHDCQJNGB(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "_ClipArgs2" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.LKPOBCBOFIC(LBHJHFGJDGQ.ToString() + "_DetailScaleX" + ECHMFPQNBMC.Required.ToString());
		float bgbmiejjqkc = 1256f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 138f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 755f);
		}
		this.EJIPFIHQQQK.FONJFPIKGEP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.DPBGHDMHKNC("-2");
		}
		else
		{
			this.QNBHJIPIDIP.JLENFJGDNFN("#,##0");
		}
	}

	// Token: 0x0600238F RID: 9103 RVA: 0x000E9244 File Offset: 0x000E7444
	public void COIMFDQIOKL(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC("ability" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + " returned its status to normal using its [ffff00]White Herb[-]!\r\n" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1795f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 1001f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1309f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.JOHBNEHCEJH("[ff6666]");
		}
		else
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ(" Lvl:");
		}
	}

	// Token: 0x06002390 RID: 9104 RVA: 0x000E8E7C File Offset: 0x000E707C
	public void HBMGCINOKBE(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x06002391 RID: 9105 RVA: 0x000E9060 File Offset: 0x000E7260
	public void MPEEPMHHDCM(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x06002392 RID: 9106 RVA: 0x000E9360 File Offset: 0x000E7560
	public void QHEJELNJQHG(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x06002393 RID: 9107 RVA: 0x0001312D File Offset: 0x0001132D
	private void GMEOCGKEOFI()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Players: ", 424f);
		}
	}

	// Token: 0x06002394 RID: 9108 RVA: 0x000E93C4 File Offset: 0x000E75C4
	public void DLEDQFJCPDJ(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC("thickfat" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "fairylock" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1421f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 1416f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 319f);
		}
		this.EJIPFIHQQQK.FONJFPIKGEP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ("Party");
		}
		else
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ("BuffIcon_EncounterRateLowered");
		}
	}

	// Token: 0x06002395 RID: 9109 RVA: 0x000E94E0 File Offset: 0x000E76E0
	public void MIEHJOOLEHC(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC("m_TangentMode" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "DATA ERROR" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1966f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 557f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 485f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.DPBGHDMHKNC("FOG_SCATTERING_ON");
		}
		else
		{
			this.QNBHJIPIDIP.JLENFJGDNFN("drought");
		}
	}

	// Token: 0x06002396 RID: 9110 RVA: 0x000E95FC File Offset: 0x000E77FC
	public void BCJPQKHQBCO(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = false;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x06002397 RID: 9111 RVA: 0x000E9660 File Offset: 0x000E7860
	public void FIJEJMDOLJN(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC("HidePanel" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "[ATK]" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1016f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 1961f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 725f);
		}
		this.EJIPFIHQQQK.BGBMIEJJQKC = bgbmiejjqkc;
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = " stronger against physical moves!\r\n";
		}
		else
		{
			this.QNBHJIPIDIP.JLENFJGDNFN(" (SoftClip)");
		}
	}

	// Token: 0x06002398 RID: 9112 RVA: 0x000E977C File Offset: 0x000E797C
	public void DFNDGODMFOM(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "1" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "/510)" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 258f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 986f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1692f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.JOHBNEHCEJH("Language");
		}
		else
		{
			this.QNBHJIPIDIP.LGJOOQIBQDC("Boosts the Pokémon's Speed stat in sunshine.");
		}
	}

	// Token: 0x06002399 RID: 9113 RVA: 0x00013152 File Offset: 0x00011352
	private void BKGJCLMIDKC()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("4_", 862f);
		}
	}

	// Token: 0x0600239A RID: 9114 RVA: 0x000E9898 File Offset: 0x000E7A98
	public void QOJOPNKQKJC(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x0600239B RID: 9115 RVA: 0x00013177 File Offset: 0x00011377
	private void JEMMIEIENOB()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Health prolongs life", 959f);
		}
	}

	// Token: 0x0600239C RID: 9116 RVA: 0x000E98FC File Offset: 0x000E7AFC
	public void OEJDMOMEKGC(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "VFMDepthCamera" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.LKPOBCBOFIC(LBHJHFGJDGQ.ToString() + "PrimitiveInnerRight" + ECHMFPQNBMC.Required.ToString());
		float bgbmiejjqkc = 839f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 1997f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1628f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.IQBBDKFDGGP("!\r\n");
		}
		else
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = "[04B9E6]Party";
		}
	}

	// Token: 0x0600239D RID: 9117 RVA: 0x0001319C File Offset: 0x0001139C
	private void ILJNLCBQHPO()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("No Guard", 1562f);
		}
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x000131C1 File Offset: 0x000113C1
	private void OnDestroy()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Reposition", 0.2f);
		}
	}

	// Token: 0x0600239F RID: 9119 RVA: 0x000E9A18 File Offset: 0x000E7C18
	public void FQFIFPGJDBE(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "Turn " + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.LKPOBCBOFIC(LBHJHFGJDGQ.ToString() + "Pixilate" + ECHMFPQNBMC.Required.ToString());
		float bgbmiejjqkc = 271f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 1794f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 497f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ(" and found it's ");
		}
		else
		{
			this.QNBHJIPIDIP.LGJOOQIBQDC("You are trying to catch fish!");
		}
	}

	// Token: 0x060023A0 RID: 9120 RVA: 0x000E90C4 File Offset: 0x000E72C4
	public void HGPDPNDJHMH(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x060023A1 RID: 9121 RVA: 0x000131E6 File Offset: 0x000113E6
	private void HFNKLOHMQFH()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("drain", 270f);
		}
	}

	// Token: 0x060023A2 RID: 9122 RVA: 0x000E9B34 File Offset: 0x000E7D34
	public void IQMKEHHHQKG(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = " declined the Guild Request." + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "spotlight" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 592f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 1482f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1864f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ("_MountTopTex");
		}
		else
		{
			this.QNBHJIPIDIP.DPBGHDMHKNC("Slow Start");
		}
	}

	// Token: 0x060023A3 RID: 9123 RVA: 0x000E9C50 File Offset: 0x000E7E50
	public void PLBJKOILHJN(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "_Female" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "slots(" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1318f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 769f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1817f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.DPBGHDMHKNC("lightmetal");
		}
		else
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = " surrounds itself with electrified terrain!\r\n";
		}
	}

	// Token: 0x060023A4 RID: 9124 RVA: 0x000E9D6C File Offset: 0x000E7F6C
	public void PBLFJLLHJFG(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC("Battle Update: " + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "/goto " + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1261f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 496f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 80f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.IQBBDKFDGGP("_Jitter");
		}
		else
		{
			this.QNBHJIPIDIP.DPBGHDMHKNC("DITHER_ON");
		}
	}

	// Token: 0x060023A5 RID: 9125 RVA: 0x000E9E88 File Offset: 0x000E8088
	public void PIDHMOPPOJK(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC("E" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "[PD]" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1826f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 528f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 538f);
		}
		this.EJIPFIHQQQK.PLLQOHPCBOP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.LGJOOQIBQDC("´");
		}
		else
		{
			this.QNBHJIPIDIP.JOHBNEHCEJH("setrandom(");
		}
	}

	// Token: 0x060023A6 RID: 9126 RVA: 0x000E9FA4 File Offset: 0x000E81A4
	public void OQJFFKJFEKG(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x060023A7 RID: 9127 RVA: 0x000EA008 File Offset: 0x000E8208
	public void FDDENOHPGQF(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC("Battle Update: " + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.LKPOBCBOFIC(LBHJHFGJDGQ.ToString() + "recoil" + ECHMFPQNBMC.Required.ToString());
		float bgbmiejjqkc = 1767f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 343f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1818f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = "EditorOnly";
		}
		else
		{
			this.QNBHJIPIDIP.JOHBNEHCEJH("Enabled");
		}
	}

	// Token: 0x060023A8 RID: 9128 RVA: 0x000EA124 File Offset: 0x000E8324
	public void IBJNQFPIMMC(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC("_Male" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "lightningrod" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1809f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 1327f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1522f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.DPBGHDMHKNC("UpdateAnchors");
		}
		else
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ("Compound Eyes");
		}
	}

	// Token: 0x060023A9 RID: 9129 RVA: 0x0001320B File Offset: 0x0001140B
	private void DHBEOHDMFDO()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("_TileX", 622f);
		}
	}

	// Token: 0x060023AA RID: 9130 RVA: 0x00013230 File Offset: 0x00011430
	private void OFKQBOLHBEP()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Doubles the Pokémon's Speed stat on Electric Terrain.", 1070f);
		}
	}

	// Token: 0x060023AB RID: 9131 RVA: 0x00013255 File Offset: 0x00011455
	private void PPIPJEGJNKM()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("stickyhold", 1249f);
		}
	}

	// Token: 0x060023AC RID: 9132 RVA: 0x000E95FC File Offset: 0x000E77FC
	public void QFHDQIDCLKP(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = false;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x060023AD RID: 9133 RVA: 0x000EA240 File Offset: 0x000E8440
	public void QKCOIIKFPKG(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC("Left" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(false);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.LKPOBCBOFIC(LBHJHFGJDGQ.ToString() + "Player/Clothe" + ECHMFPQNBMC.Required.ToString());
		float bgbmiejjqkc = 808f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 1233f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 1427f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.IQBBDKFDGGP("!\r\n");
		}
		else
		{
			this.QNBHJIPIDIP.OGQLCMOFLLQ("liquidooze");
		}
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x0001327A File Offset: 0x0001147A
	private void NICEJQLJMNQ()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Hidden/Post FX/FXAA", 674f);
		}
	}

	// Token: 0x060023AF RID: 9135 RVA: 0x000EA35C File Offset: 0x000E855C
	public void KGLLNMDPDJJ(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = false;
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x060023B0 RID: 9136 RVA: 0x000EA3C0 File Offset: 0x000E85C0
	public void PHJCHPCPLCJ(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "[ff4949]" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "Interact" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1720f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 972f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 210f);
		}
		this.EJIPFIHQQQK.FONJFPIKGEP(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.JOHBNEHCEJH("matblock");
		}
		else
		{
			this.QNBHJIPIDIP.IQBBDKFDGGP("!\r\n");
		}
	}

	// Token: 0x060023B1 RID: 9137 RVA: 0x0001329F File Offset: 0x0001149F
	private void DFLGFQLDIPI()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("[00DD00]Owned", 1895f);
		}
	}

	// Token: 0x060023B2 RID: 9138 RVA: 0x000132C4 File Offset: 0x000114C4
	private void LCGIHNGPJGF()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("liquidooze", 752f);
		}
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x000132E9 File Offset: 0x000114E9
	private void INPFOLLJMQN()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("][-][", 845f);
		}
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x0001330E File Offset: 0x0001150E
	private void GDDBJCOJNKC()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Explode", 1861f);
		}
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x000E9FA4 File Offset: 0x000E81A4
	public void GOBDNBDDBIF(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x000E9FA4 File Offset: 0x000E81A4
	public void EIOPBMLHNGN(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x000EA4DC File Offset: 0x000E86DC
	public void CLMGPMLLIDN(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.LKPOBCBOFIC(ECHMFPQNBMC.Name);
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC("0" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.LKPOBCBOFIC(LBHJHFGJDGQ.ToString() + "psn" + ECHMFPQNBMC.Required.ToString());
		float bgbmiejjqkc = 752f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 1347f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 769f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.JOHBNEHCEJH("End");
		}
		else
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = "phscore";
		}
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x00013333 File Offset: 0x00011533
	private void OEMGPILDMQQ()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("][", 1835f);
		}
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x00013358 File Offset: 0x00011558
	private void JEDENEOLFBJ()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke(" rose", 1263f);
		}
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x000EA5F8 File Offset: 0x000E87F8
	public void GNPIPCLJEJJ(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = false;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = ECHMFPQNBMC.Points.ToString();
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x000EA65C File Offset: 0x000E885C
	public void BQLIIQIIMDH(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.PIDLOFMIEFQ = ECHMFPQNBMC.Discription;
		this.EDJLCMJGKIN.PIDLOFMIEFQ = "[ACH]" + ECHMFPQNBMC.Points.ToString();
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "/" + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 0f;
		if (LBHJHFGJDGQ > 0u)
		{
			bgbmiejjqkc = 100f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 100f);
		}
		this.EJIPFIHQQQK.BGBMIEJJQKC = bgbmiejjqkc;
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = "Icon_Achievement_Complete";
		}
		else
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = "Icon_Achievement_Incomplete";
		}
	}

	// Token: 0x060023BC RID: 9148 RVA: 0x000EA778 File Offset: 0x000E8978
	public void KFFBQPOCHHE(Achievement ECHMFPQNBMC, uint LBHJHFGJDGQ)
	{
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC("The mysterious strong winds weakened the attack!\r\n" + ECHMFPQNBMC.Points.ToString());
		this.EJIPFIHQQQK.gameObject.SetActive(true);
		if (LBHJHFGJDGQ > ECHMFPQNBMC.Required)
		{
			LBHJHFGJDGQ = ECHMFPQNBMC.Required;
		}
		this.KPMCPBLCECC.PIDLOFMIEFQ = LBHJHFGJDGQ.ToString() + "The Pokémon is suffering from insomnia and cannot fall asleep." + ECHMFPQNBMC.Required.ToString();
		float bgbmiejjqkc = 1211f;
		if (LBHJHFGJDGQ > 1u)
		{
			bgbmiejjqkc = 894f / (ECHMFPQNBMC.Required / LBHJHFGJDGQ * 168f);
		}
		this.EJIPFIHQQQK.GIPBBFDPCKG(bgbmiejjqkc);
		base.gameObject.name = ECHMFPQNBMC.Name;
		if (LBHJHFGJDGQ >= ECHMFPQNBMC.Required)
		{
			this.QNBHJIPIDIP.KCLBMPFIPNQ = "Upgrading Guild";
		}
		else
		{
			this.QNBHJIPIDIP.JOHBNEHCEJH("_");
		}
	}

	// Token: 0x060023BD RID: 9149 RVA: 0x000E9360 File Offset: 0x000E7560
	public void JQLCDHBGLBI(Achievement ECHMFPQNBMC, BHLIGEGNFHG CBNJEBCHOEC)
	{
		this.JHDGENGBPQF = CBNJEBCHOEC;
		this.JDPBPOKJFQK.enabled = true;
		this.NKKMJICKKLB.PIDLOFMIEFQ = ECHMFPQNBMC.Name;
		this.KFFQQDLOLLQ.LKPOBCBOFIC(ECHMFPQNBMC.Discription);
		this.EDJLCMJGKIN.LKPOBCBOFIC(ECHMFPQNBMC.Points.ToString());
	}

	// Token: 0x040007B3 RID: 1971
	public PLQFPBQEPJD QNBHJIPIDIP;

	// Token: 0x040007B4 RID: 1972
	public PLQFPBQEPJD KIEMMQDMIIO;

	// Token: 0x040007B5 RID: 1973
	public BKKHLBCLPJM NKKMJICKKLB;

	// Token: 0x040007B6 RID: 1974
	public BKKHLBCLPJM KFFQQDLOLLQ;

	// Token: 0x040007B7 RID: 1975
	public BKKHLBCLPJM EDJLCMJGKIN;

	// Token: 0x040007B8 RID: 1976
	public JLMPBLMOICG HKLENFFCEEQ;

	// Token: 0x040007B9 RID: 1977
	public HLEKPGPJOOK EJIPFIHQQQK;

	// Token: 0x040007BA RID: 1978
	public BKKHLBCLPJM KPMCPBLCECC;

	// Token: 0x040007BB RID: 1979
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x040007BC RID: 1980
	private BHLIGEGNFHG JHDGENGBPQF;
}
