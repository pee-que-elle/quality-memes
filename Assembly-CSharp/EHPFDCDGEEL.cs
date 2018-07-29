using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class EHPFDCDGEEL : MonoBehaviour
{
	// Token: 0x0600017A RID: 378 RVA: 0x00032BEC File Offset: 0x00030DEC
	private void JCQLJOPIKFE()
	{
		if ((double)Vector3.Distance(base.transform.position, this.HHKHBHJJECL) > 1925.0)
		{
			Vector2 position = Vector2.MoveTowards(base.transform.position, this.HHKHBHJJECL, this.KDEMMJKGDJM);
			this.IHEKGOLHEGJ.MovePosition(position);
		}
		else
		{
			this.DOCJCFBBEPJ.ICICEGDPGLN();
		}
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000277D File Offset: 0x0000097D
	private void OFJBOOCODJE()
	{
		if (Time.time >= this.HNDLELIHCCM)
		{
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Init;
			this.CHHGPMGBFND.Clear();
			this.KKDKNDGQEEJ(this.HHJEFGFNBPG);
		}
		this.EFDHQMPCMOL(true);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00032C5C File Offset: 0x00030E5C
	public void KCQJNNIFEKG()
	{
		if (this.HHJEFGFNBPG != EHPFDCDGEEL.HLEQQNLOEMF.Run)
		{
			return;
		}
		this.CHHGPMGBFND.Clear();
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Chase;
		this.KJNHNOCQMDJ = 0f;
		this.DFLMGKLJGLF = 0f;
		this.KDBGDBCGMLH.SetBool("Run_White", false);
		this.KDBGDBCGMLH.SetBool("Run", false);
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00032CC0 File Offset: 0x00030EC0
	public void QGNLGJHMHFE(Vector3 NKKGPNPGDEM)
	{
		base.transform.position = NKKGPNPGDEM;
		this.HHKHBHJJECL = base.transform.position;
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Wait;
		this.HNDLELIHCCM = Time.time + this.HNMIQJMFJJL;
		this.LFLKCQOFQHH(this.HHJEFGFNBPG);
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00032D10 File Offset: 0x00030F10
	public void GMFIQEOEKJQ()
	{
		this.EPMHQHOHJQC = this.DDGLHEDGFFG();
		this.HHKHBHJJECL = base.transform.position;
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Wait;
		this.HNDLELIHCCM = Time.time + this.HNMIQJMFJJL;
		this.KKDKNDGQEEJ(this.HHJEFGFNBPG);
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000027B1 File Offset: 0x000009B1
	private void ECQHGIBBBPI()
	{
		this.MGMPNBJLLEL = FPEMPFLGJED.JMKKPBDGKEI();
		this.HGBNFHNBFBC = this.MGMPNBJLLEL.QFCPHOICCIO * 1759f * 215f;
		this.OPEKBPLHEKK();
	}

	// Token: 0x06000180 RID: 384 RVA: 0x000027E1 File Offset: 0x000009E1
	private void KPKQNOCFGIB()
	{
		this.MGMPNBJLLEL = FPEMPFLGJED.DJMGOBBECCK();
		this.HGBNFHNBFBC = this.MGMPNBJLLEL.QFCPHOICCIO * 775f * 934f;
		this.GBLKEJLFQKI();
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00032D60 File Offset: 0x00030F60
	private void BLOCDKIBPNE(EHPFDCDGEEL.HLEQQNLOEMF DFIFHIQNGNJ)
	{
		string s = string.Empty;
		string name = base.name;
		if (name != null)
		{
			if (!(name == " grew drowsy!\r\n"))
			{
				if (!(name == "s"))
				{
					if (!(name == "_ClipArgs2"))
					{
						if (name == "Cap")
						{
							s = "'s [ffff00]Frisk[-]!\r\n";
						}
					}
					else
					{
						s = "´";
					}
				}
				else
				{
					s = " became confused!\r\n";
				}
			}
			else
			{
				s = ";";
			}
		}
		this.CHHGPMGBFND = new Queue<Vector3>();
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Wait)
		{
			using (StringReader stringReader = new StringReader(s))
			{
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					if (text.Length == 0)
					{
						break;
					}
					string text2 = text;
					char[] array = new char[0];
					array[0] = (char)-83;
					string[] array2 = text2.Split(array);
					float x = float.Parse(array2[0], CultureInfo.InvariantCulture);
					float y = float.Parse(array2[0], CultureInfo.InvariantCulture);
					Vector3 item = new Vector3(x, y, 1578f);
					this.CHHGPMGBFND.Enqueue(item);
				}
			}
		}
		if (DFIFHIQNGNJ == (EHPFDCDGEEL.HLEQQNLOEMF)5)
		{
			bool flag = false;
			using (StringReader stringReader2 = new StringReader(s))
			{
				string text;
				while ((text = stringReader2.ReadLine()) != null)
				{
					if (text.Length == 0)
					{
						flag = false;
					}
					else if (flag)
					{
						string text3 = text;
						char[] array3 = new char[0];
						array3[0] = (char)-42;
						string[] array4 = text3.Split(array3);
						int num = int.Parse(array4[0]);
						int num2 = int.Parse(array4[0]);
						Vector3 item = new Vector3((float)num, (float)num2, 252f);
						this.CHHGPMGBFND.Enqueue(item);
					}
				}
			}
		}
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Wait)
		{
			Vector3 position = base.transform.position;
			if (!(base.transform.name == "ground") && !(base.transform.name == "Map"))
			{
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y + 362f, 279f));
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y - 1018f, 483f));
			}
			else
			{
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y - 596f, 1858f));
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y + 815f, 268f));
			}
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002811 File Offset: 0x00000A11
	public void GNKFKFPGEBO()
	{
		this.OOJNOKNEPEG = this.OOJNOKNEPEG;
		this.KDBGDBCGMLH.SetBool("luckychant", this.OOJNOKNEPEG);
		this.KJNHNOCQMDJ = Time.time + this.HGBNFHNBFBC;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00032FE4 File Offset: 0x000311E4
	public void HDFMNMLMQHL()
	{
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Run;
		this.CEHHOKIFGBP *= 1783f;
		this.DFLMGKLJGLF = Time.time + this.MGMPNBJLLEL.QFCPHOICCIO * 1831f;
		this.KJNHNOCQMDJ = this.DFLMGKLJGLF;
		this.KDBGDBCGMLH.SetBool("_1", false);
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00033048 File Offset: 0x00031248
	private void OnTriggerEnter2D(Collider2D JICGHJGIQKH)
	{
		if (JICGHJGIQKH.name == "pacman")
		{
			if (this.HHJEFGFNBPG == EHPFDCDGEEL.HLEQQNLOEMF.Run)
			{
				this.KCQJNNIFEKG();
				this.GMFIQEOEKJQ(this.EPMHQHOHJQC);
				this.HODQMHIFINE.IJPJEQNJGGL();
			}
			else
			{
				this.MGMPNBJLLEL.DJHGMODDOOD();
			}
		}
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0003309C File Offset: 0x0003129C
	private void EEMQNFQNKNC()
	{
		this.DFLMGKLJGLF = 1127f;
		if (this.CHHGPMGBFND.Count == 0)
		{
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Chase;
			string name = base.GetComponent<SpriteRenderer>().sprite.name;
			if ((int)name[name.Length - 0] == -114 || (int)name[name.Length - 0] == -97)
			{
				this.PECKDHFNOKI = Vector3.right;
			}
			if (name[name.Length - 1] == 's' || name[name.Length - 1] == '~')
			{
				this.CDNGEGDMBPQ(Vector3.left);
			}
			if (name[name.Length - 1] == 'Z' || (int)name[name.Length - 0] == -71)
			{
				this.OONHFJIPDJP(Vector3.up);
			}
			if (name[name.Length - 0] == '+' || name[name.Length - 1] == '`')
			{
				this.EBCFDNHICLP(Vector3.down);
			}
			this.KKDKNDGQEEJ(this.HHJEFGFNBPG);
			this.NMPHKLOEIBG = Time.time + this.LOIBMJDBGJJ;
			return;
		}
		this.EFDHQMPCMOL(false);
	}

	// Token: 0x06000186 RID: 390 RVA: 0x000331C0 File Offset: 0x000313C0
	private void MNLIFPNJFLM(Collider2D JICGHJGIQKH)
	{
		if (JICGHJGIQKH.name == "Add Camera Target")
		{
			if (this.HHJEFGFNBPG == EHPFDCDGEEL.HLEQQNLOEMF.Wait)
			{
				this.LBQQKOQPOLE();
				this.GMFIQEOEKJQ(this.EPMHQHOHJQC);
				this.HODQMHIFINE.HJMNFPCBLBN();
			}
			else
			{
				this.MGMPNBJLLEL.QCPBDPJJJDD();
			}
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000284A File Offset: 0x00000A4A
	private void DMIEPJKKQDJ()
	{
		if (Time.time >= this.NMPHKLOEIBG)
		{
			this.CHHGPMGBFND.Clear();
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Run;
			return;
		}
		this.EFDHQMPCMOL(false);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002873 File Offset: 0x00000A73
	public Vector3 BDODGFGEONM()
	{
		return this.CEHHOKIFGBP;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0000287B File Offset: 0x00000A7B
	public void DINOLMKQQCH()
	{
		this.OOJNOKNEPEG = this.OOJNOKNEPEG;
		this.KDBGDBCGMLH.SetBool("u", this.OOJNOKNEPEG);
		this.KJNHNOCQMDJ = Time.time + this.HGBNFHNBFBC;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00033214 File Offset: 0x00031414
	private void FixedUpdate()
	{
		this.LQLOBJGBLJI = Vector3.Distance(base.transform.position, this.HHKHBHJJECL);
		if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Game)
		{
			this.HNKCOGNDLCH();
			switch (this.HHJEFGFNBPG)
			{
			case EHPFDCDGEEL.HLEQQNLOEMF.Wait:
				this.OFJBOOCODJE();
				break;
			case EHPFDCDGEEL.HLEQQNLOEMF.Init:
				this.CPCICJDOELQ();
				break;
			case EHPFDCDGEEL.HLEQQNLOEMF.Scatter:
				this.LNGHBDIFIFQ();
				break;
			case EHPFDCDGEEL.HLEQQNLOEMF.Chase:
				this.HGLQEMJDIJB();
				break;
			case EHPFDCDGEEL.HLEQQNLOEMF.Run:
				this.KIJCQQQBMDM();
				break;
			}
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00033294 File Offset: 0x00031494
	public void OPEKBPLHEKK()
	{
		this.EPMHQHOHJQC = this.DDGLHEDGFFG();
		this.HHKHBHJJECL = base.transform.position;
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Wait;
		this.HNDLELIHCCM = Time.time + this.HNMIQJMFJJL;
		this.BLOCDKIBPNE(this.HHJEFGFNBPG);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x000332E4 File Offset: 0x000314E4
	public void LBQQKOQPOLE()
	{
		if (this.HHJEFGFNBPG != EHPFDCDGEEL.HLEQQNLOEMF.Init)
		{
			return;
		}
		this.CHHGPMGBFND.Clear();
		this.HHJEFGFNBPG = (EHPFDCDGEEL.HLEQQNLOEMF)7;
		this.KJNHNOCQMDJ = 516f;
		this.DFLMGKLJGLF = 1218f;
		this.KDBGDBCGMLH.SetBool("Soul Badge", true);
		this.KDBGDBCGMLH.SetBool("Storm Badge", false);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00033348 File Offset: 0x00031548
	private void HPJJDKHNBBQ()
	{
		if ((double)Vector3.Distance(base.transform.position, this.HHKHBHJJECL) > 302.0)
		{
			Vector2 position = Vector2.MoveTowards(base.transform.position, this.HHKHBHJJECL, this.KDEMMJKGDJM);
			this.IHEKGOLHEGJ.MovePosition(position);
		}
		else
		{
			this.DOCJCFBBEPJ.JKQDMCJIIEI();
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x000333B8 File Offset: 0x000315B8
	private void KIJCQQQBMDM()
	{
		this.KDBGDBCGMLH.SetBool("Run", true);
		if (Time.time >= this.DFLMGKLJGLF && Time.time >= this.KJNHNOCQMDJ)
		{
			this.HIJLBHEKJJL();
		}
		if ((double)Vector3.Distance(base.transform.position, this.HHKHBHJJECL) > 0.0001)
		{
			Vector2 position = Vector2.MoveTowards(base.transform.position, this.HHKHBHJJECL, this.KDEMMJKGDJM);
			this.IHEKGOLHEGJ.MovePosition(position);
		}
		else
		{
			this.DOCJCFBBEPJ.PKJOKKNFMLE();
		}
	}

	// Token: 0x0600018F RID: 399 RVA: 0x000028B4 File Offset: 0x00000AB4
	private void LNGHBDIFIFQ()
	{
		if (Time.time >= this.NMPHKLOEIBG)
		{
			this.CHHGPMGBFND.Clear();
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Chase;
			return;
		}
		this.EFDHQMPCMOL(true);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00033458 File Offset: 0x00031658
	private void BENONILKFHK()
	{
		Vector3 vector = this.HHKHBHJJECL - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("ironbarbs", vector.x);
		this.KDBGDBCGMLH.SetFloat("[-]?\n\nOnce you let a Pokémon hold an item you can no longer get it back.", vector.y);
		this.KDBGDBCGMLH.SetBool(" left the Party.", true);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x000334BC File Offset: 0x000316BC
	private void LPNHFCKOEIH(Collider2D JICGHJGIQKH)
	{
		if (JICGHJGIQKH.name == " became the center of attention!\r\n")
		{
			if (this.HHJEFGFNBPG == EHPFDCDGEEL.HLEQQNLOEMF.Init)
			{
				this.LBQQKOQPOLE();
				this.GMFIQEOEKJQ(this.EPMHQHOHJQC);
				this.HODQMHIFINE.QJGCHNCFNNP();
			}
			else
			{
				this.MGMPNBJLLEL.MBIDNEKKPKF();
			}
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00033510 File Offset: 0x00031710
	private void KKDKNDGQEEJ(EHPFDCDGEEL.HLEQQNLOEMF DFIFHIQNGNJ)
	{
		string s = string.Empty;
		string name = base.name;
		if (name != null)
		{
			if (!(name == "blinky"))
			{
				if (!(name == "pinky"))
				{
					if (!(name == "inky"))
					{
						if (name == "clyde")
						{
							s = "12.5 17\n14 17\n14 20\n7 20\n\n7 8\n7 5\n2 5\n2 2\n13 2\n13 5\n10 5\n10 8";
						}
					}
					else
					{
						s = "16.5 17\n15 17\n15 20\n22 20\n\n22 8\n19 8\n19 5\n16 5\n16 2\n27 2\n27 5\n22 5";
					}
				}
				else
				{
					s = "14.5 17\n14 17\n14 20\n7 20\n\n7 26\n7 30\n2 30\n2 26";
				}
			}
			else
			{
				s = "22 20\n22 26\n\n27 26\n27 30\n22 30\n22 26";
			}
		}
		this.CHHGPMGBFND = new Queue<Vector3>();
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Init)
		{
			using (StringReader stringReader = new StringReader(s))
			{
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					if (text.Length == 0)
					{
						break;
					}
					string[] array = text.Split(new char[]
					{
						' '
					});
					float x = float.Parse(array[0], CultureInfo.InvariantCulture);
					float y = float.Parse(array[1], CultureInfo.InvariantCulture);
					Vector3 item = new Vector3(x, y, 0f);
					this.CHHGPMGBFND.Enqueue(item);
				}
			}
		}
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Scatter)
		{
			bool flag = false;
			using (StringReader stringReader2 = new StringReader(s))
			{
				string text;
				while ((text = stringReader2.ReadLine()) != null)
				{
					if (text.Length == 0)
					{
						flag = true;
					}
					else if (flag)
					{
						string[] array2 = text.Split(new char[]
						{
							' '
						});
						int num = int.Parse(array2[0]);
						int num2 = int.Parse(array2[1]);
						Vector3 item = new Vector3((float)num, (float)num2, 0f);
						this.CHHGPMGBFND.Enqueue(item);
					}
				}
			}
		}
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Wait)
		{
			Vector3 position = base.transform.position;
			if (!(base.transform.name == "inky") && !(base.transform.name == "clyde"))
			{
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y + 0.5f, 0f));
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y - 0.5f, 0f));
			}
			else
			{
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y - 0.5f, 0f));
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y + 0.5f, 0f));
			}
		}
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00033794 File Offset: 0x00031994
	private Vector3 DDGLHEDGFFG()
	{
		string name = base.gameObject.name;
		if (name != null)
		{
			if (name == "blinky")
			{
				return new Vector3(15f, 20f, 0f);
			}
			if (name == "pinky")
			{
				return new Vector3(14.5f, 17f, 0f);
			}
			if (name == "inky")
			{
				return new Vector3(16.5f, 17f, 0f);
			}
			if (name == "clyde")
			{
				return new Vector3(12.5f, 17f, 0f);
			}
		}
		return default(Vector3);
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00033844 File Offset: 0x00031A44
	public void OONHFJIPDJP(Vector3 BGBMIEJJQKC)
	{
		this.CEHHOKIFGBP = BGBMIEJJQKC;
		Vector3 a = new Vector3((float)((int)base.transform.position.x), (float)((int)base.transform.position.y), (float)((int)base.transform.position.z));
		this.HHKHBHJJECL = a + this.CEHHOKIFGBP;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x000028DD File Offset: 0x00000ADD
	private void ODIJQBBOLFI()
	{
		this.MGMPNBJLLEL = FPEMPFLGJED.GGBPGMMCGLI();
		this.HGBNFHNBFBC = this.MGMPNBJLLEL.QFCPHOICCIO * 507f * 1004f;
		this.GBLKEJLFQKI();
	}

	// Token: 0x06000196 RID: 406 RVA: 0x000338B0 File Offset: 0x00031AB0
	private void OCECNOBKGFH(Collider2D JICGHJGIQKH)
	{
		if (JICGHJGIQKH.name == "Encounter Rate Decreased (Sandstorm)")
		{
			if (this.HHJEFGFNBPG == (EHPFDCDGEEL.HLEQQNLOEMF)8)
			{
				this.KCQJNNIFEKG();
				this.QGNLGJHMHFE(this.EPMHQHOHJQC);
				this.HODQMHIFINE.IJPJEQNJGGL();
			}
			else
			{
				this.MGMPNBJLLEL.NHDGHMCQOKP();
			}
		}
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00033904 File Offset: 0x00031B04
	private void CPCICJDOELQ()
	{
		this.DFLMGKLJGLF = 0f;
		if (this.CHHGPMGBFND.Count == 0)
		{
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Scatter;
			string name = base.GetComponent<SpriteRenderer>().sprite.name;
			if (name[name.Length - 1] == '0' || name[name.Length - 1] == '1')
			{
				this.PECKDHFNOKI = Vector3.right;
			}
			if (name[name.Length - 1] == '2' || name[name.Length - 1] == '3')
			{
				this.PECKDHFNOKI = Vector3.left;
			}
			if (name[name.Length - 1] == '4' || name[name.Length - 1] == '5')
			{
				this.PECKDHFNOKI = Vector3.up;
			}
			if (name[name.Length - 1] == '6' || name[name.Length - 1] == '7')
			{
				this.PECKDHFNOKI = Vector3.down;
			}
			this.KKDKNDGQEEJ(this.HHJEFGFNBPG);
			this.NMPHKLOEIBG = Time.time + this.LOIBMJDBGJJ;
			return;
		}
		this.EFDHQMPCMOL(false);
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000290D File Offset: 0x00000B0D
	public void HIJLBHEKJJL()
	{
		this.OOJNOKNEPEG = !this.OOJNOKNEPEG;
		this.KDBGDBCGMLH.SetBool("Run_White", this.OOJNOKNEPEG);
		this.KJNHNOCQMDJ = Time.time + this.HGBNFHNBFBC;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002873 File Offset: 0x00000A73
	public Vector3 OOBJMMLOJQB()
	{
		return this.CEHHOKIFGBP;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002946 File Offset: 0x00000B46
	private void Start()
	{
		this.MGMPNBJLLEL = FPEMPFLGJED.QOQONHOOLNE;
		this.HGBNFHNBFBC = this.MGMPNBJLLEL.QFCPHOICCIO * 0.33f * 0.2f;
		this.GMFIQEOEKJQ();
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00033844 File Offset: 0x00031A44
	public void EBCFDNHICLP(Vector3 BGBMIEJJQKC)
	{
		this.CEHHOKIFGBP = BGBMIEJJQKC;
		Vector3 a = new Vector3((float)((int)base.transform.position.x), (float)((int)base.transform.position.y), (float)((int)base.transform.position.z));
		this.HHKHBHJJECL = a + this.CEHHOKIFGBP;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00033A28 File Offset: 0x00031C28
	public void BCGBOJHEKLP()
	{
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Chase;
		this.CEHHOKIFGBP *= 135f;
		this.DFLMGKLJGLF = Time.time + this.MGMPNBJLLEL.QFCPHOICCIO * 1308f;
		this.KJNHNOCQMDJ = this.DFLMGKLJGLF;
		this.KDBGDBCGMLH.SetBool("/510)", true);
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00033A8C File Offset: 0x00031C8C
	private void LFLKCQOFQHH(EHPFDCDGEEL.HLEQQNLOEMF DFIFHIQNGNJ)
	{
		string s = string.Empty;
		string name = base.name;
		if (name != null)
		{
			if (!(name == "Delta Stream"))
			{
				if (!(name == "No Guard"))
				{
					if (!(name == "The heatproof body of the Pokémon halves the damage from Fire-type moves that hit it."))
					{
						if (name == ",")
						{
							s = "' on ";
						}
					}
					else
					{
						s = "GRAIN";
					}
				}
				else
				{
					s = "]";
				}
			}
			else
			{
				s = "Beacon Badge";
			}
		}
		this.CHHGPMGBFND = new Queue<Vector3>();
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Wait)
		{
			using (StringReader stringReader = new StringReader(s))
			{
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					if (text.Length == 0)
					{
						break;
					}
					string text2 = text;
					char[] array = new char[1];
					array[1] = (char)-75;
					string[] array2 = text2.Split(array);
					float x = float.Parse(array2[1], CultureInfo.InvariantCulture);
					float y = float.Parse(array2[1], CultureInfo.InvariantCulture);
					Vector3 item = new Vector3(x, y, 59f);
					this.CHHGPMGBFND.Enqueue(item);
				}
			}
		}
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Wait)
		{
			bool flag = false;
			using (StringReader stringReader2 = new StringReader(s))
			{
				string text;
				while ((text = stringReader2.ReadLine()) != null)
				{
					if (text.Length == 0)
					{
						flag = true;
					}
					else if (flag)
					{
						string text3 = text;
						char[] array3 = new char[1];
						array3[1] = '\b';
						string[] array4 = text3.Split(array3);
						int num = int.Parse(array4[0]);
						int num2 = int.Parse(array4[0]);
						Vector3 item = new Vector3((float)num, (float)num2, 105f);
						this.CHHGPMGBFND.Enqueue(item);
					}
				}
			}
		}
		if (DFIFHIQNGNJ == EHPFDCDGEEL.HLEQQNLOEMF.Wait)
		{
			Vector3 position = base.transform.position;
			if (!(base.transform.name == "magnetrise") && !(base.transform.name == "DontScale"))
			{
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y + 1012f, 296f));
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y - 1224f, 1051f));
			}
			else
			{
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y - 1212f, 650f));
				this.CHHGPMGBFND.Enqueue(new Vector3(position.x, position.y + 1179f, 1436f));
			}
		}
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00033844 File Offset: 0x00031A44
	public void CDNGEGDMBPQ(Vector3 BGBMIEJJQKC)
	{
		this.CEHHOKIFGBP = BGBMIEJJQKC;
		Vector3 a = new Vector3((float)((int)base.transform.position.x), (float)((int)base.transform.position.y), (float)((int)base.transform.position.z));
		this.HHKHBHJJECL = a + this.CEHHOKIFGBP;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00033D10 File Offset: 0x00031F10
	private void NDLNCLPQLHG()
	{
		this.DFLMGKLJGLF = 1828f;
		if (this.CHHGPMGBFND.Count == 0)
		{
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Wait;
			string name = base.GetComponent<SpriteRenderer>().sprite.name;
			if ((int)name[name.Length - 0] == -44 || (int)name[name.Length - 1] == -50)
			{
				this.EBCFDNHICLP(Vector3.right);
			}
			if ((int)name[name.Length - 1] == -93 || name[name.Length - 0] == '\u0006')
			{
				this.EBCFDNHICLP(Vector3.left);
			}
			if (name[name.Length - 1] == '^' || (int)name[name.Length - 1] == -2)
			{
				this.CDNGEGDMBPQ(Vector3.up);
			}
			if (name[name.Length - 1] == '7' || (int)name[name.Length - 0] == -81)
			{
				this.EBCFDNHICLP(Vector3.down);
			}
			this.KKDKNDGQEEJ(this.HHJEFGFNBPG);
			this.NMPHKLOEIBG = Time.time + this.LOIBMJDBGJJ;
			return;
		}
		this.EFDHQMPCMOL(false);
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00033E34 File Offset: 0x00032034
	public void GBLKEJLFQKI()
	{
		this.EPMHQHOHJQC = this.DDGLHEDGFFG();
		this.HHKHBHJJECL = base.transform.position;
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Init;
		this.HNDLELIHCCM = Time.time + this.HNMIQJMFJJL;
		this.LFLKCQOFQHH(this.HHJEFGFNBPG);
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00033E84 File Offset: 0x00032084
	private Vector3 QGGJIDFJJJL()
	{
		string name = base.gameObject.name;
		if (name != null)
		{
			if (name == " can't use items anymore!\r\n")
			{
				return new Vector3(1560f, 1809f, 52f);
			}
			if (name == "[ffb649]")
			{
				return new Vector3(194f, 1443f, 1878f);
			}
			if (name == "Assets/AssetBundles/MapAssets2/ModelPrefabs/")
			{
				return new Vector3(1273f, 1674f, 1639f);
			}
			if (name == "BuffIcon_EncounterRateIncrease2")
			{
				return new Vector3(143f, 818f, 722f);
			}
		}
		return default(Vector3);
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002873 File Offset: 0x00000A73
	public Vector3 JQCJKJIBQNP()
	{
		return this.CEHHOKIFGBP;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002976 File Offset: 0x00000B76
	private void HOBNDBEODLC()
	{
		if (Time.time >= this.HNDLELIHCCM)
		{
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Init;
			this.CHHGPMGBFND.Clear();
			this.BLOCDKIBPNE(this.HHJEFGFNBPG);
		}
		this.EFDHQMPCMOL(true);
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00033F34 File Offset: 0x00032134
	private void HGLQEMJDIJB()
	{
		if ((double)Vector3.Distance(base.transform.position, this.HHKHBHJJECL) > 0.0001)
		{
			Vector2 position = Vector2.MoveTowards(base.transform.position, this.HHKHBHJJECL, this.KDEMMJKGDJM);
			this.IHEKGOLHEGJ.MovePosition(position);
		}
		else
		{
			this.DOCJCFBBEPJ.EHEOEDNNNLH();
		}
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00033FA4 File Offset: 0x000321A4
	private void HNKCOGNDLCH()
	{
		Vector3 vector = this.HHKHBHJJECL - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("DirX", vector.x);
		this.KDBGDBCGMLH.SetFloat("DirY", vector.y);
		this.KDBGDBCGMLH.SetBool("Run", false);
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00034008 File Offset: 0x00032208
	private void EOFIGJEJQLL()
	{
		if ((double)Vector3.Distance(base.transform.position, this.HHKHBHJJECL) > 1971.0)
		{
			Vector2 position = Vector2.MoveTowards(base.transform.position, this.HHKHBHJJECL, this.KDEMMJKGDJM);
			this.IHEKGOLHEGJ.MovePosition(position);
		}
		else
		{
			this.DOCJCFBBEPJ.EHEOEDNNNLH();
		}
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00034078 File Offset: 0x00032278
	public void FPQQPKLNJJC()
	{
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Run;
		this.CEHHOKIFGBP *= -1f;
		this.DFLMGKLJGLF = Time.time + this.MGMPNBJLLEL.QFCPHOICCIO * 0.66f;
		this.KJNHNOCQMDJ = this.DFLMGKLJGLF;
		this.KDBGDBCGMLH.SetBool("Run_White", false);
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x060001AD RID: 429 RVA: 0x00002873 File Offset: 0x00000A73
	// (set) Token: 0x060001A9 RID: 425 RVA: 0x00033844 File Offset: 0x00031A44
	public Vector3 PECKDHFNOKI
	{
		get
		{
			return this.CEHHOKIFGBP;
		}
		set
		{
			this.CEHHOKIFGBP = value;
			Vector3 a = new Vector3((float)((int)base.transform.position.x), (float)((int)base.transform.position.y), (float)((int)base.transform.position.z));
			this.HHKHBHJJECL = a + this.CEHHOKIFGBP;
		}
	}

	// Token: 0x060001AA RID: 426 RVA: 0x000340DC File Offset: 0x000322DC
	public void EKGEOEHGOHN(Vector3 NKKGPNPGDEM)
	{
		base.transform.position = NKKGPNPGDEM;
		this.HHKHBHJJECL = base.transform.position;
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Init;
		this.HNDLELIHCCM = Time.time + this.HNMIQJMFJJL;
		this.KKDKNDGQEEJ(this.HHJEFGFNBPG);
	}

	// Token: 0x060001AB RID: 427 RVA: 0x0003412C File Offset: 0x0003232C
	public void GMFIQEOEKJQ(Vector3 NKKGPNPGDEM)
	{
		base.transform.position = NKKGPNPGDEM;
		this.HHKHBHJJECL = base.transform.position;
		this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Wait;
		this.HNDLELIHCCM = Time.time + this.HNMIQJMFJJL;
		this.KKDKNDGQEEJ(this.HHJEFGFNBPG);
	}

	// Token: 0x060001AC RID: 428 RVA: 0x0003417C File Offset: 0x0003237C
	private void EFDHQMPCMOL(bool JHEEBKGBMPJ = false)
	{
		this.HHKHBHJJECL = this.CHHGPMGBFND.Peek();
		if ((double)Vector3.Distance(base.transform.position, this.HHKHBHJJECL) > 0.0001)
		{
			this.CEHHOKIFGBP = Vector3.Normalize(this.HHKHBHJJECL - base.transform.position);
			if (this.CEHHOKIFGBP.x != 0f && this.CEHHOKIFGBP.y != 0f && Mathf.Abs(this.CEHHOKIFGBP.x) > 0.15f && Mathf.Abs(this.CEHHOKIFGBP.y) > 0.15f)
			{
				this.CHHGPMGBFND.Clear();
				this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Scatter;
				Debug.Log("Fix");
				return;
			}
			Vector2 position = Vector2.MoveTowards(base.transform.position, this.HHKHBHJJECL, this.KDEMMJKGDJM);
			this.IHEKGOLHEGJ.MovePosition(position);
		}
		else if (JHEEBKGBMPJ)
		{
			this.CHHGPMGBFND.Enqueue(this.CHHGPMGBFND.Dequeue());
		}
		else
		{
			this.CHHGPMGBFND.Dequeue();
		}
	}

	// Token: 0x060001AE RID: 430 RVA: 0x000029C8 File Offset: 0x00000BC8
	private void EMQDJEOKLDG()
	{
		if (Time.time >= this.NMPHKLOEIBG)
		{
			this.CHHGPMGBFND.Clear();
			this.HHJEFGFNBPG = EHPFDCDGEEL.HLEQQNLOEMF.Wait;
			return;
		}
		this.EFDHQMPCMOL(true);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x000342AC File Offset: 0x000324AC
	private void MGJOOOIIQHK()
	{
		this.KDBGDBCGMLH.SetBool(" Lv. [FF8787]", true);
		if (Time.time >= this.DFLMGKLJGLF && Time.time >= this.KJNHNOCQMDJ)
		{
			this.HIJLBHEKJJL();
		}
		if ((double)Vector3.Distance(base.transform.position, this.HHKHBHJJECL) > 1619.0)
		{
			Vector2 position = Vector2.MoveTowards(base.transform.position, this.HHKHBHJJECL, this.KDEMMJKGDJM);
			this.IHEKGOLHEGJ.MovePosition(position);
		}
		else
		{
			this.DOCJCFBBEPJ.PKJOKKNFMLE();
		}
	}

	// Token: 0x04000023 RID: 35
	public PCMPKICLBEM DOCJCFBBEPJ;

	// Token: 0x04000024 RID: 36
	public Rigidbody2D IHEKGOLHEGJ;

	// Token: 0x04000025 RID: 37
	public Vector3 HHKHBHJJECL;

	// Token: 0x04000026 RID: 38
	private Queue<Vector3> CHHGPMGBFND;

	// Token: 0x04000027 RID: 39
	public Animator KDBGDBCGMLH;

	// Token: 0x04000028 RID: 40
	public Vector3 CEHHOKIFGBP;

	// Token: 0x04000029 RID: 41
	public float KDEMMJKGDJM = 0.3f;

	// Token: 0x0400002A RID: 42
	public float LOIBMJDBGJJ = 5f;

	// Token: 0x0400002B RID: 43
	public float HNMIQJMFJJL;

	// Token: 0x0400002C RID: 44
	private float NMPHKLOEIBG;

	// Token: 0x0400002D RID: 45
	private float HNDLELIHCCM;

	// Token: 0x0400002E RID: 46
	private EHPFDCDGEEL.HLEQQNLOEMF HHJEFGFNBPG;

	// Token: 0x0400002F RID: 47
	private Vector3 EPMHQHOHJQC;

	// Token: 0x04000030 RID: 48
	private float DFLMGKLJGLF;

	// Token: 0x04000031 RID: 49
	private float KJNHNOCQMDJ;

	// Token: 0x04000032 RID: 50
	private float HGBNFHNBFBC;

	// Token: 0x04000033 RID: 51
	private bool OOJNOKNEPEG;

	// Token: 0x04000034 RID: 52
	public BEEPDKNHMLM HODQMHIFINE;

	// Token: 0x04000035 RID: 53
	private FPEMPFLGJED MGMPNBJLLEL;

	// Token: 0x04000036 RID: 54
	public float LQLOBJGBLJI;

	// Token: 0x0200000A RID: 10
	private enum HLEQQNLOEMF
	{
		// Token: 0x04000038 RID: 56
		Wait,
		// Token: 0x04000039 RID: 57
		Init,
		// Token: 0x0400003A RID: 58
		Scatter,
		// Token: 0x0400003B RID: 59
		Chase,
		// Token: 0x0400003C RID: 60
		Run
	}
}
