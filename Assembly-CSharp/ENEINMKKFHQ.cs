using System;
using PSXAPI.Request;
using UnityEngine;

// Token: 0x02000294 RID: 660
public class ENEINMKKFHQ : MonoBehaviour
{
	// Token: 0x06005BD9 RID: 23513 RVA: 0x000241D5 File Offset: 0x000223D5
	private void QOGBNEJFCFJ()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005BDA RID: 23514 RVA: 0x002F4DA4 File Offset: 0x002F2FA4
	public void GMNEDFPNMIE()
	{
		if (this.IGEGBJLDIGJ.BGBMIEJJQKC.Length < 2)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
	}

	// Token: 0x06005BDB RID: 23515 RVA: 0x002F4E04 File Offset: 0x002F3004
	public void PFIGIEQMKFD()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		this.IGEGBJLDIGJ.BGBMIEJJQKC = string.Empty;
		this.NFKFIJIFNEM();
		base.CancelInvoke("Failed to use '");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1185f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005BDC RID: 23516 RVA: 0x000241DD File Offset: 0x000223DD
	private void OKPEJEGBPEI()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005BDD RID: 23517 RVA: 0x000241F0 File Offset: 0x000223F0
	public void GMEFIOJFDMM()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Remove from Friends", 1225f);
	}

	// Token: 0x06005BDE RID: 23518 RVA: 0x00024219 File Offset: 0x00022419
	public void MQIKJNPIQQJ()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Input - PMChat", 1551f);
	}

	// Token: 0x06005BDF RID: 23519 RVA: 0x002F4E9C File Offset: 0x002F309C
	public void LOJDEDMDLQQ()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.GMEFIOJFDMM();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = (VerifyEmailAction)7,
			Username = this.MBPHKDQMJJH
		}, true);
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x000241D5 File Offset: 0x000223D5
	private void PCHJHFGCOCK()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x00024242 File Offset: 0x00022442
	private void ONCLNDJDLGJ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005BE3 RID: 23523 RVA: 0x00024242 File Offset: 0x00022442
	private void BPNPHLMGBMB()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005BE4 RID: 23524 RVA: 0x00024242 File Offset: 0x00022442
	private void CELNOJJDQBK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005BE5 RID: 23525 RVA: 0x002F4F00 File Offset: 0x002F3100
	public void IFHCPQKOFJO()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.JMIOGDFLEDC();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = VerifyEmailAction.None,
			Username = this.MBPHKDQMJJH
		}, true);
	}

	// Token: 0x06005BE6 RID: 23526 RVA: 0x002F4F64 File Offset: 0x002F3164
	public void JPPLIJPIMCM()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.JMIOGDFLEDC();
			return;
		}
		int code = 0;
		int.TryParse(this.IGEGBJLDIGJ.HJMJDJKOILH(), out code);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, false);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x06005BE7 RID: 23527 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ QOQONHOOLNE
	{
		get
		{
			return ENEINMKKFHQ.HBFFCJHOCPE;
		}
	}

	// Token: 0x06005BE8 RID: 23528 RVA: 0x0002426F File Offset: 0x0002246F
	public void OFENPQQHIPN()
	{
		this.JMIOGDFLEDC();
		GDDKPIHHICF.QOQONHOOLNE.NJNCGMFPHFI();
	}

	// Token: 0x06005BE9 RID: 23529 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ LQIDEJOEHNH()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005BEA RID: 23530 RVA: 0x002F4FD8 File Offset: 0x002F31D8
	public void CPCOKKLMDJB()
	{
		if (this.IGEGBJLDIGJ.BGBMIEJJQKC.Length < 7)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
	}

	// Token: 0x06005BEB RID: 23531 RVA: 0x00024281 File Offset: 0x00022481
	public void JMIOGDFLEDC()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.", 816f);
	}

	// Token: 0x06005BEC RID: 23532 RVA: 0x000241D5 File Offset: 0x000223D5
	private void NNPPKOGDNOM()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005BED RID: 23533 RVA: 0x002F5038 File Offset: 0x002F3238
	public void Open()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		this.IGEGBJLDIGJ.BGBMIEJJQKC = string.Empty;
		this.CheckCode();
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005BEE RID: 23534 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ MMFDGHKCCJF()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005BEF RID: 23535 RVA: 0x000241D5 File Offset: 0x000223D5
	private void LFJEJGOMLPI()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005BF0 RID: 23536 RVA: 0x002F50D0 File Offset: 0x002F32D0
	public void NLFLJDFOFLF()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.HDQPGPMIJGH();
			return;
		}
		int code = 1;
		int.TryParse(this.IGEGBJLDIGJ.HJMJDJKOILH(), out code);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, true);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06005BF1 RID: 23537 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ QIGQGGGPGGP()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005BF2 RID: 23538 RVA: 0x000242AA File Offset: 0x000224AA
	public void LEMJGJGCGNF()
	{
		this.HDQPGPMIJGH();
		GDDKPIHHICF.QOQONHOOLNE.NJNCGMFPHFI();
	}

	// Token: 0x06005BF3 RID: 23539 RVA: 0x000242BC File Offset: 0x000224BC
	public void OQOMPEMMDNQ()
	{
		this.PBPCFIJBJDB();
		GDDKPIHHICF.QOQONHOOLNE.HPPGOGQHCFG();
	}

	// Token: 0x06005BF4 RID: 23540 RVA: 0x002F5144 File Offset: 0x002F3344
	public void MEOBCFLICJI()
	{
		if (this.IGEGBJLDIGJ.BGBMIEJJQKC.Length < 0)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x06005BF5 RID: 23541 RVA: 0x00024242 File Offset: 0x00022442
	private void IDEJFKDOGIB()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005BF6 RID: 23542 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ GHFFHFCEENG()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005BF7 RID: 23543 RVA: 0x000241DD File Offset: 0x000223DD
	private void PLONIIIOMFP()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005BF8 RID: 23544 RVA: 0x002F51A4 File Offset: 0x002F33A4
	public void IQNDLMPECBB()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.JMIOGDFLEDC();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new VerifyEmail
		{
			Action = (VerifyEmailAction)3,
			Username = this.MBPHKDQMJJH
		}, false);
	}

	// Token: 0x06005BF9 RID: 23545 RVA: 0x000241D5 File Offset: 0x000223D5
	private void QHQEBPKMNLD()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005BFA RID: 23546 RVA: 0x002F5208 File Offset: 0x002F3408
	public void NFKFIJIFNEM()
	{
		if (this.IGEGBJLDIGJ.BGBMIEJJQKC.Length < 2)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = false;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
	}

	// Token: 0x06005BFB RID: 23547 RVA: 0x000241D5 File Offset: 0x000223D5
	private void Awake()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005BFC RID: 23548 RVA: 0x000241DD File Offset: 0x000223DD
	private void MQKMIOHNQCK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005BFD RID: 23549 RVA: 0x000242CE File Offset: 0x000224CE
	public void Cancel()
	{
		this.Close();
		GDDKPIHHICF.QOQONHOOLNE.NJNCGMFPHFI();
	}

	// Token: 0x06005BFE RID: 23550 RVA: 0x002F5268 File Offset: 0x002F3468
	public void JKFLENKJQFD()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.HDQPGPMIJGH();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = (VerifyEmailAction)3,
			Username = this.MBPHKDQMJJH
		}, false);
	}

	// Token: 0x06005BFF RID: 23551 RVA: 0x000241DD File Offset: 0x000223DD
	private void QKQBMQIGMOJ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005C00 RID: 23552 RVA: 0x002F52CC File Offset: 0x002F34CC
	public void GJQCFGIFCID()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.GMEFIOJFDMM();
			return;
		}
		int code = 1;
		int.TryParse(this.IGEGBJLDIGJ.HJMJDJKOILH(), out code);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, true);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06005C01 RID: 23553 RVA: 0x000242E0 File Offset: 0x000224E0
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06005C02 RID: 23554 RVA: 0x00024309 File Offset: 0x00022509
	public void EMQNOCQMFQF()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("-mega-y", 643f);
	}

	// Token: 0x06005C03 RID: 23555 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ EOOEINHFBOK()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005C04 RID: 23556 RVA: 0x00024242 File Offset: 0x00022442
	private void KPMMHQOMJEF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005C05 RID: 23557 RVA: 0x00024332 File Offset: 0x00022532
	public void PBPCFIJBJDB()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("pacman", 828f);
	}

	// Token: 0x06005C06 RID: 23558 RVA: 0x002F5340 File Offset: 0x002F3540
	public void FELQLCJFOMP()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.HDQPGPMIJGH();
			return;
		}
		int code = 1;
		int.TryParse(this.IGEGBJLDIGJ.BGBMIEJJQKC, out code);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, true);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06005C07 RID: 23559 RVA: 0x002F53B4 File Offset: 0x002F35B4
	public void CGBGQBFBLIJ()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = false;
		this.IGEGBJLDIGJ.NCBFKNGMKPB(string.Empty);
		this.MEOBCFLICJI();
		base.CancelInvoke(" type!\r\n");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1701f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005C08 RID: 23560 RVA: 0x0002435B File Offset: 0x0002255B
	public void MFHICLLNLIP()
	{
		this.PBPCFIJBJDB();
		GDDKPIHHICF.QOQONHOOLNE.DEBGPFHHPMM();
	}

	// Token: 0x06005C09 RID: 23561 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ QDGLKKGJDGI()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005C0A RID: 23562 RVA: 0x002F544C File Offset: 0x002F364C
	public void Submit()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.Close();
			return;
		}
		int code = 0;
		int.TryParse(this.IGEGBJLDIGJ.BGBMIEJJQKC, out code);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, false);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06005C0B RID: 23563 RVA: 0x0002436D File Offset: 0x0002256D
	public void DJKOFIDODQH()
	{
		this.EMQNOCQMFQF();
		GDDKPIHHICF.QOQONHOOLNE.HPPGOGQHCFG();
	}

	// Token: 0x06005C0C RID: 23564 RVA: 0x0002437F File Offset: 0x0002257F
	public void NOPHLNMOMQI()
	{
		this.Close();
		GDDKPIHHICF.QOQONHOOLNE.FGQOFOQMNID();
	}

	// Token: 0x06005C0D RID: 23565 RVA: 0x002F54C0 File Offset: 0x002F36C0
	public void HQCNPOPPIQL()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		this.IGEGBJLDIGJ.NCBFKNGMKPB(string.Empty);
		this.MEOBCFLICJI();
		base.CancelInvoke("~");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 660f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005C0E RID: 23566 RVA: 0x0002435B File Offset: 0x0002255B
	public void PEEIOLFIMOF()
	{
		this.PBPCFIJBJDB();
		GDDKPIHHICF.QOQONHOOLNE.DEBGPFHHPMM();
	}

	// Token: 0x06005C0F RID: 23567 RVA: 0x002F5558 File Offset: 0x002F3758
	public void NHFQKBOMHGE()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = false;
		this.IGEGBJLDIGJ.BGBMIEJJQKC = string.Empty;
		this.CPCOKKLMDJB();
		base.CancelInvoke("WATER_REFRACTIVE");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1739f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005C10 RID: 23568 RVA: 0x000241D5 File Offset: 0x000223D5
	private void OHNCEMNBBPF()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005C11 RID: 23569 RVA: 0x002F55F0 File Offset: 0x002F37F0
	public void CheckCode()
	{
		if (this.IGEGBJLDIGJ.BGBMIEJJQKC.Length < 6)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = false;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
	}

	// Token: 0x06005C12 RID: 23570 RVA: 0x002F5650 File Offset: 0x002F3850
	public void BEPKHCENQFE()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.JMIOGDFLEDC();
			return;
		}
		int code = 1;
		int.TryParse(this.IGEGBJLDIGJ.BGBMIEJJQKC, out code);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, false);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06005C13 RID: 23571 RVA: 0x002F56C4 File Offset: 0x002F38C4
	public void LFJNQCNHDEE()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.MQIKJNPIQQJ();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = (VerifyEmailAction)8,
			Username = this.MBPHKDQMJJH
		}, false);
	}

	// Token: 0x06005C14 RID: 23572 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ HGEKKNEPOHK()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005C15 RID: 23573 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ BBCBOIFQDBK()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005C16 RID: 23574 RVA: 0x00024242 File Offset: 0x00022442
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005C17 RID: 23575 RVA: 0x000241DD File Offset: 0x000223DD
	private void MEHMOBGFPFN()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005C18 RID: 23576 RVA: 0x000241DD File Offset: 0x000223DD
	private void PHFEEOFGMHO()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005C19 RID: 23577 RVA: 0x000241D5 File Offset: 0x000223D5
	private void PEOBQCMFLML()
	{
		ENEINMKKFHQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005C1A RID: 23578 RVA: 0x00024391 File Offset: 0x00022591
	public void JPMPHONKEMO()
	{
		this.OKIIELLBQLB();
		GDDKPIHHICF.QOQONHOOLNE.FGQOFOQMNID();
	}

	// Token: 0x06005C1B RID: 23579 RVA: 0x002F5728 File Offset: 0x002F3928
	public void KIDQJPCNBCG()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		this.IGEGBJLDIGJ.NCBFKNGMKPB(string.Empty);
		this.MEOBCFLICJI();
		base.CancelInvoke("System Message");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 913f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005C1C RID: 23580 RVA: 0x002F57C0 File Offset: 0x002F39C0
	public void CDBPNGDIBNG()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.OKIIELLBQLB();
			return;
		}
		int code = 1;
		int.TryParse(this.IGEGBJLDIGJ.HJMJDJKOILH(), out code);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new VerifyEmail
		{
			Action = VerifyEmailAction.None,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, false);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06005C1D RID: 23581 RVA: 0x002F5834 File Offset: 0x002F3A34
	public void NQGLJCKLIHH()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.HDQPGPMIJGH();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = (VerifyEmailAction)6,
			Username = this.MBPHKDQMJJH
		}, false);
	}

	// Token: 0x06005C1E RID: 23582 RVA: 0x002F5898 File Offset: 0x002F3A98
	public void QPJDLDFNNPJ()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		this.IGEGBJLDIGJ.NCBFKNGMKPB(string.Empty);
		this.MEOBCFLICJI();
		base.CancelInvoke("_FogData2");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1690f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005C1F RID: 23583 RVA: 0x000243A3 File Offset: 0x000225A3
	public void HDQPGPMIJGH()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("/Model.prefab", 1792f);
	}

	// Token: 0x06005C20 RID: 23584 RVA: 0x002F5930 File Offset: 0x002F3B30
	public void MKEHCQFPCMI()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.JMIOGDFLEDC();
			return;
		}
		int code = 0;
		int.TryParse(this.IGEGBJLDIGJ.HJMJDJKOILH(), out code);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, false);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06005C21 RID: 23585 RVA: 0x002F59A4 File Offset: 0x002F3BA4
	public void BOLKLGDFGOL()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.PBPCFIJBJDB();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH
		}, false);
	}

	// Token: 0x06005C22 RID: 23586 RVA: 0x002F5A08 File Offset: 0x002F3C08
	public void QJCEFOIOHNL()
	{
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = false;
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		this.IGEGBJLDIGJ.BGBMIEJJQKC = string.Empty;
		this.MEOBCFLICJI();
		base.CancelInvoke("Max:");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1979f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005C23 RID: 23587 RVA: 0x002F5AA0 File Offset: 0x002F3CA0
	public void LDKNLMPCOQL()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.MQIKJNPIQQJ();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = true;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new VerifyEmail
		{
			Action = VerifyEmailAction.None,
			Username = this.MBPHKDQMJJH
		}, false);
	}

	// Token: 0x06005C24 RID: 23588 RVA: 0x002F5B04 File Offset: 0x002F3D04
	public void JLNJEEDOBDL()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.PBPCFIJBJDB();
			return;
		}
		int code = 1;
		int.TryParse(this.IGEGBJLDIGJ.HJMJDJKOILH(), out code);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new VerifyEmail
		{
			Action = VerifyEmailAction.Verify,
			Username = this.MBPHKDQMJJH,
			Code = code
		}, true);
		this.IGEGBJLDIGJ.GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06005C25 RID: 23589 RVA: 0x002F5B78 File Offset: 0x002F3D78
	public void OGGMCCLOJLG()
	{
		if (this.IGEGBJLDIGJ.HJMJDJKOILH().Length < 2)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x06005C26 RID: 23590 RVA: 0x00024268 File Offset: 0x00022468
	public static ENEINMKKFHQ CLPQIKCDHPP()
	{
		return ENEINMKKFHQ.HBFFCJHOCPE;
	}

	// Token: 0x06005C27 RID: 23591 RVA: 0x002F5BD8 File Offset: 0x002F3DD8
	public void GDGFPOEODHL()
	{
		if (this.IGEGBJLDIGJ.BGBMIEJJQKC.Length < 4)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = false;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x06005C28 RID: 23592 RVA: 0x002F5C38 File Offset: 0x002F3E38
	public void BLOJIBKPEME()
	{
		if (this.IGEGBJLDIGJ.HJMJDJKOILH().Length < 0)
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, true);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.EQMGNGHKJKK.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.EQMGNGHKJKK.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x06005C29 RID: 23593 RVA: 0x0002435B File Offset: 0x0002255B
	public void KPLJQJFLODL()
	{
		this.PBPCFIJBJDB();
		GDDKPIHHICF.QOQONHOOLNE.DEBGPFHHPMM();
	}

	// Token: 0x06005C2A RID: 23594 RVA: 0x002F5C98 File Offset: 0x002F3E98
	public void Resend()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.Close();
			return;
		}
		this.EKIHQDFKPOM.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.EKIHQDFKPOM.GetComponent<BoxCollider>().enabled = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new VerifyEmail
		{
			Action = VerifyEmailAction.Resend,
			Username = this.MBPHKDQMJJH
		}, false);
	}

	// Token: 0x06005C2B RID: 23595 RVA: 0x000243CC File Offset: 0x000225CC
	public void OKIIELLBQLB()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("truant", 1046f);
	}

	// Token: 0x040013E3 RID: 5091
	private static ENEINMKKFHQ HBFFCJHOCPE;

	// Token: 0x040013E4 RID: 5092
	public JIMBBPLINGI IGEGBJLDIGJ;

	// Token: 0x040013E5 RID: 5093
	public string MBPHKDQMJJH = string.Empty;

	// Token: 0x040013E6 RID: 5094
	public CFDMNELIJLO EQMGNGHKJKK;

	// Token: 0x040013E7 RID: 5095
	public CFDMNELIJLO EKIHQDFKPOM;

	// Token: 0x040013E8 RID: 5096
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x040013E9 RID: 5097
	public EPIJJNOIKEK JDPBPOKJFQK;
}
