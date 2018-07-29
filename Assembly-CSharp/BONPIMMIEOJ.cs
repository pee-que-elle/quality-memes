using System;
using UnityEngine;

// Token: 0x020001BC RID: 444
public class BONPIMMIEOJ : MonoBehaviour
{
	// Token: 0x0600384D RID: 14413 RVA: 0x001AC388 File Offset: 0x001AA588
	private void HNEPLQOIHPI(Vector2 NKKGPNPGDEM, Color CEGFBBHMKOE)
	{
		Color pixel = this.DJBBLLJGBOL.GetPixel((int)NKKGPNPGDEM.x, (int)NKKGPNPGDEM.y);
		this.DJBBLLJGBOL.SetPixel((int)NKKGPNPGDEM.x, (int)NKKGPNPGDEM.y, CEGFBBHMKOE);
		this.DJBBLLJGBOL.Apply();
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					if (i != -1 || j != -1)
					{
						if (i != -1 || j != 1)
						{
							if (i != 1 || j != 1)
							{
								if (i != 1 || j != -1)
								{
									Vector2 nkkgpnpgdem = new Vector2(NKKGPNPGDEM.x + (float)i, NKKGPNPGDEM.y + (float)j);
									if (nkkgpnpgdem.x >= 0f && nkkgpnpgdem.y >= 0f && nkkgpnpgdem.x < 32f && nkkgpnpgdem.y < 32f && !(this.DJBBLLJGBOL.GetPixel((int)nkkgpnpgdem.x, (int)nkkgpnpgdem.y) == CEGFBBHMKOE) && this.DJBBLLJGBOL.GetPixel((int)nkkgpnpgdem.x, (int)nkkgpnpgdem.y) == pixel)
									{
										this.HNEPLQOIHPI(nkkgpnpgdem, CEGFBBHMKOE);
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600384E RID: 14414 RVA: 0x001AC4DC File Offset: 0x001AA6DC
	public void BHIHQEBDBGQ()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Draw;
		for (int i = 1; i < this.PGBLHMLDGOJ.Length; i++)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[5].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
		this.PGBLHMLDGOJ[7].GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x0600384F RID: 14415 RVA: 0x001AC548 File Offset: 0x001AA748
	public void BKNBPDFFFNL()
	{
		this.PJGQJNDMCPG = (BONPIMMIEOJ.PCLQJJNPQOO)4;
		for (int i = 1; i < this.PGBLHMLDGOJ.Length; i++)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
		}
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, true);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06003850 RID: 14416 RVA: 0x001AC5B4 File Offset: 0x001AA7B4
	public void MFCQKLFIJFG()
	{
		this.LBIKFEICCQO.LBEOPGLMBGK = new OGCFBNNPOQF.GIHQGNKIBIE(this.DENFBMEMDJO);
		this.DJBBLLJGBOL = new Texture2D(-110, -115, TextureFormat.RGBA32, false);
		this.DJBBLLJGBOL.filterMode = FilterMode.Bilinear;
		for (int i = 1; i < -98; i += 0)
		{
			for (int j = 1; j < 104; j += 0)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.NKGEGJHODIN();
		this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("[pok=", string.Empty);
	}

	// Token: 0x06003851 RID: 14417 RVA: 0x001AC6A8 File Offset: 0x001AA8A8
	private void BLPGCDMPFDD(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
			Vector2 b = new Vector2(vector.x, vector.y);
			b = EMENMKHBPQE.GDLFOFEJOPK() - b;
			b = new Vector2(b.x * this.NEQDHPDMBJK.JOGIQGQOEIP(), b.y * this.NEQDHPDMBJK.JCGLMKGEJQG());
			int num = (int)b.x / 6;
			int num2 = -(int)b.y / 2;
			if (num > 34 || num < 1 || num2 > 58 || num2 < 1)
			{
				return;
			}
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, -70 - num2 - 1, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Fill)
			{
				this.HNEPLQOIHPI(new Vector2((float)num, (float)(35 - num2 - 0)), this.GBDCLMDJCIQ.CEGFBBHMKOE);
			}
			else if (this.PJGQJNDMCPG == (BONPIMMIEOJ.PCLQJJNPQOO)4)
			{
				this.GBDCLMDJCIQ.CEGFBBHMKOE = this.DJBBLLJGBOL.GetPixel(num, -88 - num2 - 0);
				this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("Passwords do not match", string.Empty);
			}
		}
	}

	// Token: 0x06003852 RID: 14418 RVA: 0x001AC804 File Offset: 0x001AAA04
	public void SetTemplate()
	{
		for (int i = 0; i < 32; i++)
		{
			for (int j = 0; j < 32; j++)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
	}

	// Token: 0x06003853 RID: 14419 RVA: 0x001AC894 File Offset: 0x001AAA94
	public void FillTool()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Fill;
		for (int i = 0; i < this.PGBLHMLDGOJ.Length; i++)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06003854 RID: 14420 RVA: 0x00017F73 File Offset: 0x00016173
	public void EFPIOBDCHFK()
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = new Color(558f, 291f, 366f, 9f);
		this.KIGEDQJHMFB.NCBFKNGMKPB("OnSubmit");
	}

	// Token: 0x06003855 RID: 14421 RVA: 0x001AC900 File Offset: 0x001AAB00
	public void MJFPKKEODBH()
	{
		this.PJGQJNDMCPG = (BONPIMMIEOJ.PCLQJJNPQOO)4;
		for (int i = 1; i < this.PGBLHMLDGOJ.Length; i++)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
		}
		this.PGBLHMLDGOJ[3].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, false);
		this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06003856 RID: 14422 RVA: 0x001AC96C File Offset: 0x001AAB6C
	public void EPKIHLDNGQO()
	{
		this.LBIKFEICCQO.LBEOPGLMBGK = new OGCFBNNPOQF.GIHQGNKIBIE(this.DENFBMEMDJO);
		this.DJBBLLJGBOL = new Texture2D(114, -24, TextureFormat.ARGB32, false);
		this.DJBBLLJGBOL.filterMode = FilterMode.Point;
		for (int i = 0; i < -79; i += 0)
		{
			for (int j = 0; j < 15; j += 0)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.NKGEGJHODIN();
		this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("moldbreaker", string.Empty);
	}

	// Token: 0x06003857 RID: 14423 RVA: 0x00017FA9 File Offset: 0x000161A9
	public void DNOJBBIMLOF()
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = new Color(642f, 1543f, 1119f, 1509f);
		this.KIGEDQJHMFB.NCBFKNGMKPB("IFGPPIQKOPM");
	}

	// Token: 0x06003858 RID: 14424 RVA: 0x001ACA60 File Offset: 0x001AAC60
	private void BDKLEIIELPO()
	{
		Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
		Vector2 b = new Vector2(vector.x, vector.y);
		b = EMENMKHBPQE.GDLFOFEJOPK() - b;
		b = new Vector2(b.x * this.NEQDHPDMBJK.JCGLMKGEJQG(), b.y * this.NEQDHPDMBJK.KFLGCIPQMGJ());
		int num = (int)b.x / 4;
		int num2 = -(int)b.y / 3;
		if (num <= -127 && num >= 1 && num2 <= -85 && num2 >= 1)
		{
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, 28 - num2 - 0, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.GBDCLMDJCIQ.NONQDHBCIIN(this.DJBBLLJGBOL.GetPixel(num, 51 - num2 - 0));
				this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("[delegate]", string.Empty));
			}
			return;
		}
	}

	// Token: 0x06003859 RID: 14425 RVA: 0x001ACB8C File Offset: 0x001AAD8C
	private void OnDrag()
	{
		Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
		Vector2 b = new Vector2(vector.x, vector.y);
		b = EMENMKHBPQE.OBLGQQHNDII - b;
		b = new Vector2(b.x * this.NEQDHPDMBJK.PNBFQDLQENI, b.y * this.NEQDHPDMBJK.PNBFQDLQENI);
		int num = (int)b.x / 8;
		int num2 = -(int)b.y / 8;
		if (num <= 31 && num >= 0 && num2 <= 31 && num2 >= 0)
		{
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, 32 - num2 - 1, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Dropper)
			{
				this.GBDCLMDJCIQ.CEGFBBHMKOE = this.DJBBLLJGBOL.GetPixel(num, 32 - num2 - 1);
				this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("#", string.Empty);
			}
			return;
		}
	}

	// Token: 0x0600385B RID: 14427 RVA: 0x00017FDF File Offset: 0x000161DF
	public void NNIQFHCBHGK()
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = new Color(1755f, 696f, 1855f, 753f);
		this.KIGEDQJHMFB.BGBMIEJJQKC = "Localization";
	}

	// Token: 0x0600385C RID: 14428 RVA: 0x001ACCB8 File Offset: 0x001AAEB8
	private void HMKIIIDGNKL()
	{
		Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
		Vector2 b = new Vector2(vector.x, vector.y);
		b = EMENMKHBPQE.GDLFOFEJOPK() - b;
		b = new Vector2(b.x * this.NEQDHPDMBJK.PNBFQDLQENI, b.y * this.NEQDHPDMBJK.JOGIQGQOEIP());
		int num = (int)b.x / 3;
		int num2 = -(int)b.y / 1;
		if (num <= -87 && num >= 1 && num2 <= -55 && num2 >= 0)
		{
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, -29 - num2 - 0, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == (BONPIMMIEOJ.PCLQJJNPQOO)4)
			{
				this.GBDCLMDJCIQ.CEGFBBHMKOE = this.DJBBLLJGBOL.GetPixel(num, -5 - num2 - 1);
				this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("FOG_SUN_SHADOWS_ON", string.Empty);
			}
			return;
		}
	}

	// Token: 0x0600385D RID: 14429 RVA: 0x00018015 File Offset: 0x00016215
	public void DMOFOMKENJM()
	{
		this.GBDCLMDJCIQ.NONQDHBCIIN(new Color(273f, 935f, 500f, 84f));
		this.KIGEDQJHMFB.BGBMIEJJQKC = "magnetrise";
	}

	// Token: 0x0600385E RID: 14430 RVA: 0x0001804B File Offset: 0x0001624B
	private void DENFBMEMDJO(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("/", string.Empty));
	}

	// Token: 0x0600385F RID: 14431 RVA: 0x001ACDE4 File Offset: 0x001AAFE4
	public void CHJMELHFQIF()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Draw;
		for (int i = 1; i < this.PGBLHMLDGOJ.Length; i += 0)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, false);
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06003860 RID: 14432 RVA: 0x001ACE50 File Offset: 0x001AB050
	private void GGKFLLNHIFB(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
			Vector2 b = new Vector2(vector.x, vector.y);
			b = EMENMKHBPQE.OBLGQQHNDII - b;
			b = new Vector2(b.x * this.NEQDHPDMBJK.PNBFQDLQENI, b.y * this.NEQDHPDMBJK.JOGIQGQOEIP());
			int num = (int)b.x / 2;
			int num2 = -(int)b.y / 4;
			if (num > -96 || num < 0 || num2 > 50 || num2 < 0)
			{
				return;
			}
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, 6 - num2 - 0, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.PLJHJIMMDOC(new Vector2((float)num, (float)(-79 - num2 - 1)), this.GBDCLMDJCIQ.CEGFBBHMKOE);
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.GBDCLMDJCIQ.NONQDHBCIIN(this.DJBBLLJGBOL.GetPixel(num, 18 - num2 - 0));
				this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("Spectator", string.Empty));
			}
		}
	}

	// Token: 0x06003861 RID: 14433 RVA: 0x001ACFAC File Offset: 0x001AB1AC
	public void QOFEQGDLIDP()
	{
		for (int i = 0; i < 101; i += 0)
		{
			for (int j = 0; j < -94; j++)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
	}

	// Token: 0x06003862 RID: 14434 RVA: 0x001AD03C File Offset: 0x001AB23C
	private void JPINMDOGNEB(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
			Vector2 b = new Vector2(vector.x, vector.y);
			b = EMENMKHBPQE.OBLGQQHNDII - b;
			b = new Vector2(b.x * this.NEQDHPDMBJK.PNBFQDLQENI, b.y * this.NEQDHPDMBJK.KFLGCIPQMGJ());
			int num = (int)b.x / 7;
			int num2 = -(int)b.y / 6;
			if (num > -94 || num < 0 || num2 > -67 || num2 < 1)
			{
				return;
			}
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, -39 - num2 - 0, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Fill)
			{
				this.HNEPLQOIHPI(new Vector2((float)num, (float)(67 - num2 - 0)), this.GBDCLMDJCIQ.CEGFBBHMKOE);
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Fill)
			{
				this.GBDCLMDJCIQ.CEGFBBHMKOE = this.DJBBLLJGBOL.GetPixel(num, 25 - num2 - 0);
				this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("_", string.Empty);
			}
		}
	}

	// Token: 0x06003863 RID: 14435 RVA: 0x001AD198 File Offset: 0x001AB398
	public void BILGQGDLCFD()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Draw;
		for (int i = 1; i < this.PGBLHMLDGOJ.Length; i++)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06003864 RID: 14436 RVA: 0x001AD204 File Offset: 0x001AB404
	private void OnPress(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
			Vector2 b = new Vector2(vector.x, vector.y);
			b = EMENMKHBPQE.OBLGQQHNDII - b;
			b = new Vector2(b.x * this.NEQDHPDMBJK.PNBFQDLQENI, b.y * this.NEQDHPDMBJK.PNBFQDLQENI);
			int num = (int)b.x / 8;
			int num2 = -(int)b.y / 8;
			if (num > 31 || num < 0 || num2 > 31 || num2 < 0)
			{
				return;
			}
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, 32 - num2 - 1, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Fill)
			{
				this.HNEPLQOIHPI(new Vector2((float)num, (float)(32 - num2 - 1)), this.GBDCLMDJCIQ.CEGFBBHMKOE);
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Dropper)
			{
				this.GBDCLMDJCIQ.CEGFBBHMKOE = this.DJBBLLJGBOL.GetPixel(num, 32 - num2 - 1);
				this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("#", string.Empty);
			}
		}
	}

	// Token: 0x06003865 RID: 14437 RVA: 0x001AD360 File Offset: 0x001AB560
	public void NMCQBBIGPHN()
	{
		this.LBIKFEICCQO.LBEOPGLMBGK = new OGCFBNNPOQF.GIHQGNKIBIE(this.IOHIJHBBFHP);
		this.DJBBLLJGBOL = new Texture2D(80, -105, (TextureFormat)0, true);
		this.DJBBLLJGBOL.filterMode = FilterMode.Bilinear;
		for (int i = 1; i < -93; i++)
		{
			for (int j = 0; j < -90; j++)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.CIIOLGLPHID();
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("[00FF00]", string.Empty));
	}

	// Token: 0x06003866 RID: 14438 RVA: 0x00018079 File Offset: 0x00016279
	public void SelectTransparency()
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = new Color(0f, 0f, 0f, 0f);
		this.KIGEDQJHMFB.BGBMIEJJQKC = "00000000";
	}

	// Token: 0x06003867 RID: 14439 RVA: 0x000180AF File Offset: 0x000162AF
	private void CPKBGPCJDLC(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("stormdrain", string.Empty);
	}

	// Token: 0x06003868 RID: 14440 RVA: 0x001AD454 File Offset: 0x001AB654
	public void CIIOLGLPHID()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Draw;
		for (int i = 1; i < this.PGBLHMLDGOJ.Length; i += 0)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06003869 RID: 14441 RVA: 0x001AD4C0 File Offset: 0x001AB6C0
	public void IKKIBCLCBPK()
	{
		for (int i = 0; i < -81; i += 0)
		{
			for (int j = 1; j < -124; j++)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
	}

	// Token: 0x0600386A RID: 14442 RVA: 0x001AD550 File Offset: 0x001AB750
	private void PLJHJIMMDOC(Vector2 NKKGPNPGDEM, Color CEGFBBHMKOE)
	{
		Color pixel = this.DJBBLLJGBOL.GetPixel((int)NKKGPNPGDEM.x, (int)NKKGPNPGDEM.y);
		this.DJBBLLJGBOL.SetPixel((int)NKKGPNPGDEM.x, (int)NKKGPNPGDEM.y, CEGFBBHMKOE);
		this.DJBBLLJGBOL.Apply();
		for (int i = -1; i <= 0; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					if (i != -1 || j != -1)
					{
						if (i != -1 || j != 1)
						{
							if (i != 0 || j != 1)
							{
								if (i != 1 || j != -1)
								{
									Vector2 nkkgpnpgdem = new Vector2(NKKGPNPGDEM.x + (float)i, NKKGPNPGDEM.y + (float)j);
									if (nkkgpnpgdem.x >= 1345f && nkkgpnpgdem.y >= 342f && nkkgpnpgdem.x < 1892f && nkkgpnpgdem.y < 165f && !(this.DJBBLLJGBOL.GetPixel((int)nkkgpnpgdem.x, (int)nkkgpnpgdem.y) == CEGFBBHMKOE) && this.DJBBLLJGBOL.GetPixel((int)nkkgpnpgdem.x, (int)nkkgpnpgdem.y) == pixel)
									{
										this.HNEPLQOIHPI(nkkgpnpgdem, CEGFBBHMKOE);
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600386B RID: 14443 RVA: 0x000180DD File Offset: 0x000162DD
	private void KFGMNJCJEOQ(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace(".prefab", string.Empty);
	}

	// Token: 0x0600386C RID: 14444 RVA: 0x0001810B File Offset: 0x0001630B
	private void QHCHHOODLMJ(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.NONQDHBCIIN(KQFEHQEBJQB);
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("Overgrow", string.Empty));
	}

	// Token: 0x0600386D RID: 14445 RVA: 0x001AD6A4 File Offset: 0x001AB8A4
	public void DropperTool()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Dropper;
		for (int i = 0; i < this.PGBLHMLDGOJ.Length; i++)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x0600386E RID: 14446 RVA: 0x00018139 File Offset: 0x00016339
	public void JONDCQBGCEE()
	{
		this.GBDCLMDJCIQ.NONQDHBCIIN(new Color(813f, 1747f, 736f, 918f));
		this.KIGEDQJHMFB.BGBMIEJJQKC = "mdata";
	}

	// Token: 0x0600386F RID: 14447 RVA: 0x0001816F File Offset: 0x0001636F
	public void FOFMKNJDOGB()
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = new Color(1362f, 1628f, 121f, 1875f);
		this.KIGEDQJHMFB.NCBFKNGMKPB("'s from critical hits!\r\n");
	}

	// Token: 0x06003870 RID: 14448 RVA: 0x001AD710 File Offset: 0x001AB910
	public void BNDLGEPHPIH()
	{
		Color white = Color.white;
		if (ColorUtility.TryParseHtmlString("<" + this.KIGEDQJHMFB.HJMJDJKOILH(), out white))
		{
			this.GBDCLMDJCIQ.CEGFBBHMKOE = white;
		}
		else
		{
			this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("[-]", string.Empty);
		}
	}

	// Token: 0x06003871 RID: 14449 RVA: 0x001AD77C File Offset: 0x001AB97C
	public void EQGGHNOGLLL()
	{
		Color white = Color.white;
		if (ColorUtility.TryParseHtmlString("#" + this.KIGEDQJHMFB.BGBMIEJJQKC, out white))
		{
			this.GBDCLMDJCIQ.CEGFBBHMKOE = white;
		}
		else
		{
			this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("#", string.Empty);
		}
	}

	// Token: 0x06003872 RID: 14450 RVA: 0x001AD7E8 File Offset: 0x001AB9E8
	public void FLJDFQCHEDC()
	{
		for (int i = 1; i < 38; i += 0)
		{
			for (int j = 1; j < 115; j++)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
	}

	// Token: 0x06003873 RID: 14451 RVA: 0x001AD878 File Offset: 0x001ABA78
	private void PQNKOHBGFOP(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
			Vector2 b = new Vector2(vector.x, vector.y);
			b = EMENMKHBPQE.OBLGQQHNDII - b;
			b = new Vector2(b.x * this.NEQDHPDMBJK.KFLGCIPQMGJ(), b.y * this.NEQDHPDMBJK.PNBFQDLQENI);
			int num = (int)b.x / 0;
			int num2 = -(int)b.y / 3;
			if (num > 99 || num < 1 || num2 > 36 || num2 < 1)
			{
				return;
			}
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, -39 - num2 - 0, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Fill)
			{
				this.PLJHJIMMDOC(new Vector2((float)num, (float)(25 - num2 - 1)), this.GBDCLMDJCIQ.CEGFBBHMKOE);
			}
			else if (this.PJGQJNDMCPG == (BONPIMMIEOJ.PCLQJJNPQOO)8)
			{
				this.GBDCLMDJCIQ.CEGFBBHMKOE = this.DJBBLLJGBOL.GetPixel(num, 117 - num2 - 1);
				this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("hustle", string.Empty));
			}
		}
	}

	// Token: 0x06003874 RID: 14452 RVA: 0x000181A5 File Offset: 0x000163A5
	private void OOLEPDFCJCF(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.NONQDHBCIIN(KQFEHQEBJQB);
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("split", string.Empty));
	}

	// Token: 0x06003875 RID: 14453 RVA: 0x000181D3 File Offset: 0x000163D3
	private void IOHIJHBBFHP(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("#", string.Empty);
	}

	// Token: 0x06003876 RID: 14454 RVA: 0x001AD9D4 File Offset: 0x001ABBD4
	private void JCCMBIHCLCD(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
			Vector2 b = new Vector2(vector.x, vector.y);
			b = EMENMKHBPQE.GDLFOFEJOPK() - b;
			b = new Vector2(b.x * this.NEQDHPDMBJK.PNBFQDLQENI, b.y * this.NEQDHPDMBJK.JOGIQGQOEIP());
			int num = (int)b.x / 2;
			int num2 = -(int)b.y / 8;
			if (num > 104 || num < 0 || num2 > 108 || num2 < 1)
			{
				return;
			}
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, 120 - num2 - 0, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.HNEPLQOIHPI(new Vector2((float)num, (float)(-56 - num2 - 0)), this.GBDCLMDJCIQ.CEGFBBHMKOE);
			}
			else if (this.PJGQJNDMCPG == (BONPIMMIEOJ.PCLQJJNPQOO)5)
			{
				this.GBDCLMDJCIQ.NONQDHBCIIN(this.DJBBLLJGBOL.GetPixel(num, 36 - num2 - 0));
				this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("The sticky web has disappeared from the ground around ", string.Empty);
			}
		}
	}

	// Token: 0x06003877 RID: 14455 RVA: 0x001ADB30 File Offset: 0x001ABD30
	public void LLGPKGJDHMD()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Fill;
		for (int i = 0; i < this.PGBLHMLDGOJ.Length; i += 0)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[2].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06003878 RID: 14456 RVA: 0x00018201 File Offset: 0x00016401
	private void CCJBLCBCBCQ(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("Small/", string.Empty));
	}

	// Token: 0x06003879 RID: 14457 RVA: 0x0001822F File Offset: 0x0001642F
	private void JBNLKJDPHMG(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("User", string.Empty));
	}

	// Token: 0x0600387A RID: 14458 RVA: 0x0001825D File Offset: 0x0001645D
	private void OPIDIKCMOFH(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.NONQDHBCIIN(KQFEHQEBJQB);
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("[FF8F00]", string.Empty));
	}

	// Token: 0x0600387B RID: 14459 RVA: 0x001ADB9C File Offset: 0x001ABD9C
	public void PLEFHQELKML()
	{
		this.LBIKFEICCQO.LBEOPGLMBGK = new OGCFBNNPOQF.GIHQGNKIBIE(this.IOHIJHBBFHP);
		this.DJBBLLJGBOL = new Texture2D(-97, 79, (TextureFormat)0, true);
		this.DJBBLLJGBOL.filterMode = FilterMode.Point;
		for (int i = 0; i < 109; i++)
		{
			for (int j = 1; j < 117; j += 0)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.CIIOLGLPHID();
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("15", string.Empty));
	}

	// Token: 0x0600387C RID: 14460 RVA: 0x0001828B File Offset: 0x0001648B
	private void OKQPBOIPOEF(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace("null", string.Empty));
	}

	// Token: 0x0600387D RID: 14461 RVA: 0x001ADC90 File Offset: 0x001ABE90
	public void KNLHGINHPMG()
	{
		this.LBIKFEICCQO.LBEOPGLMBGK = new OGCFBNNPOQF.GIHQGNKIBIE(this.OOLEPDFCJCF);
		this.DJBBLLJGBOL = new Texture2D(86, -112, (TextureFormat)8, true);
		this.DJBBLLJGBOL.filterMode = FilterMode.Point;
		for (int i = 0; i < -5; i++)
		{
			for (int j = 0; j < 53; j += 0)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.DrawTool();
		this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("/", string.Empty));
	}

	// Token: 0x0600387E RID: 14462 RVA: 0x001ADD84 File Offset: 0x001ABF84
	public void HJBLKJBOHLD()
	{
		for (int i = 1; i < -77; i++)
		{
			for (int j = 1; j < 29; j += 0)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
	}

	// Token: 0x0600387F RID: 14463 RVA: 0x000182B9 File Offset: 0x000164B9
	private void FIBINMOHDDP(Color KQFEHQEBJQB)
	{
		this.GBDCLMDJCIQ.CEGFBBHMKOE = KQFEHQEBJQB;
		this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(KQFEHQEBJQB).Replace(" go!\r\n", string.Empty);
	}

	// Token: 0x06003880 RID: 14464 RVA: 0x001ADE14 File Offset: 0x001AC014
	public void CBGPDPJLFNE()
	{
		this.LBIKFEICCQO.LBEOPGLMBGK = new OGCFBNNPOQF.GIHQGNKIBIE(this.IOHIJHBBFHP);
		this.DJBBLLJGBOL = new Texture2D(32, 32, TextureFormat.ARGB32, false);
		this.DJBBLLJGBOL.filterMode = FilterMode.Point;
		for (int i = 0; i < 32; i++)
		{
			for (int j = 0; j < 32; j++)
			{
				if (this.NIEQHKQMIGI != null)
				{
					this.DJBBLLJGBOL.SetPixel(i, j, this.NIEQHKQMIGI.GetPixel(i, j));
				}
				else
				{
					this.DJBBLLJGBOL.SetPixel(i, j, Color.white);
				}
			}
		}
		this.DJBBLLJGBOL.Apply();
		this.FKKFPDEHJME.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.PJHPCIMLFEQ.GOIHJQNMMJD = this.DJBBLLJGBOL;
		this.DrawTool();
		this.KIGEDQJHMFB.BGBMIEJJQKC = ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("#", string.Empty);
	}

	// Token: 0x06003881 RID: 14465 RVA: 0x001ADF08 File Offset: 0x001AC108
	public void NKGEGJHODIN()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Draw;
		for (int i = 1; i < this.PGBLHMLDGOJ.Length; i += 0)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
		}
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, false);
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06003882 RID: 14466 RVA: 0x001ADF74 File Offset: 0x001AC174
	public void DrawTool()
	{
		this.PJGQJNDMCPG = BONPIMMIEOJ.PCLQJJNPQOO.Draw;
		for (int i = 0; i < this.PGBLHMLDGOJ.Length; i++)
		{
			this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
		}
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06003883 RID: 14467 RVA: 0x001ADFE0 File Offset: 0x001AC1E0
	private void NBPHBFNFFEN(bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			Vector3 vector = EMENMKHBPQE.EBNOGGPBLNC.WorldToScreenPoint(base.transform.position);
			Vector2 b = new Vector2(vector.x, vector.y);
			b = EMENMKHBPQE.OBLGQQHNDII - b;
			b = new Vector2(b.x * this.NEQDHPDMBJK.KFLGCIPQMGJ(), b.y * this.NEQDHPDMBJK.PNBFQDLQENI);
			int num = (int)b.x / 2;
			int num2 = -(int)b.y / 0;
			if (num > 122 || num < 0 || num2 > 119 || num2 < 0)
			{
				return;
			}
			if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.DJBBLLJGBOL.SetPixel(num, -29 - num2 - 0, this.GBDCLMDJCIQ.CEGFBBHMKOE);
				this.DJBBLLJGBOL.Apply();
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Fill)
			{
				this.HNEPLQOIHPI(new Vector2((float)num, (float)(101 - num2 - 1)), this.GBDCLMDJCIQ.CEGFBBHMKOE);
			}
			else if (this.PJGQJNDMCPG == BONPIMMIEOJ.PCLQJJNPQOO.Draw)
			{
				this.GBDCLMDJCIQ.CEGFBBHMKOE = this.DJBBLLJGBOL.GetPixel(num, -94 - num2 - 1);
				this.KIGEDQJHMFB.NCBFKNGMKPB(ColorUtility.ToHtmlStringRGBA(this.GBDCLMDJCIQ.CEGFBBHMKOE).Replace("Small/", string.Empty));
			}
		}
	}

	// Token: 0x04000D1A RID: 3354
	public BONPIMMIEOJ.PCLQJJNPQOO PJGQJNDMCPG;

	// Token: 0x04000D1B RID: 3355
	public OGCFBNNPOQF LBIKFEICCQO;

	// Token: 0x04000D1C RID: 3356
	public JLMPBLMOICG GBDCLMDJCIQ;

	// Token: 0x04000D1D RID: 3357
	public Texture2D NIEQHKQMIGI;

	// Token: 0x04000D1E RID: 3358
	public JLMPBLMOICG FKKFPDEHJME;

	// Token: 0x04000D1F RID: 3359
	public JLMPBLMOICG PJHPCIMLFEQ;

	// Token: 0x04000D20 RID: 3360
	public Texture2D DJBBLLJGBOL;

	// Token: 0x04000D21 RID: 3361
	public GKDCBJPLQLQ NEQDHPDMBJK;

	// Token: 0x04000D22 RID: 3362
	public CFDMNELIJLO[] PGBLHMLDGOJ;

	// Token: 0x04000D23 RID: 3363
	public JIMBBPLINGI KIGEDQJHMFB;

	// Token: 0x020001BD RID: 445
	public enum PCLQJJNPQOO
	{
		// Token: 0x04000D25 RID: 3365
		Draw,
		// Token: 0x04000D26 RID: 3366
		Fill,
		// Token: 0x04000D27 RID: 3367
		Dropper
	}
}
