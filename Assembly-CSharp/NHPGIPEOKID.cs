using System;
using System.Collections.Generic;
using System.Globalization;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x020001C6 RID: 454
public class NHPGIPEOKID : MonoBehaviour
{
	// Token: 0x060039E6 RID: 14822 RVA: 0x00018ABA File Offset: 0x00016CBA
	private void CIJOENOQKCI()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.OFBGHIBHBLI = 0;
		this.QKNLQGJDMNP.JILGPKIOILF = false;
	}

	// Token: 0x060039E7 RID: 14823 RVA: 0x001B5A94 File Offset: 0x001B3C94
	public void KFCICKPDQJO(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string[] array = new string[4];
			array[1] = "Egg";
			array[0] = item.ID.EBGLBFKHCJD();
			array[7] = "Wild Encounters:";
			array[0] = item.DFNQHDEDDKE();
			array[2] = "electricterrain";
			string text = string.Concat(array);
			if (this.QKNLQGJDMNP.HJMJDJKOILH().Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC = qknlqgjdmnp.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060039E8 RID: 14824 RVA: 0x001B5B30 File Offset: 0x001B3D30
	public void DDGGOHGDNLD(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string[] array = new string[6];
			array[0] = "After your payment has been verified your Lootboxes will be added to your account.";
			array[0] = item.HLMQODIHBIG().EBGLBFKHCJD();
			array[7] = "#,##0";
			array[1] = item.JQBDPHILQJO();
			array[5] = "[NGUI] Mesh";
			string text = string.Concat(array);
			if (this.QKNLQGJDMNP.BGBMIEJJQKC.Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060039E9 RID: 14825 RVA: 0x001B5BCC File Offset: 0x001B3DCC
	public void BFEKQBJQMDQ(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			string[] array = new string[5];
			array[1] = "shscore";
			array[1] = item.HLMQODIHBIG().EBGLBFKHCJD();
			array[3] = "[-] was taken over!\r\n";
			array[1] = item.NDPGCGDLEEQ();
			array[1] = "Mold Breaker";
			string text = string.Concat(array);
			if (this.QKNLQGJDMNP.HJMJDJKOILH().Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060039EA RID: 14826 RVA: 0x001B5C68 File Offset: 0x001B3E68
	public void QDGCMCIMPLE(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string[] array = new string[6];
			array[0] = "-mega-x";
			array[0] = item.ID.EBGLBFKHCJD();
			array[6] = "Fen Badge";
			array[5] = item.Name;
			array[7] = " shared its power with the target!\r\n";
			string text = string.Concat(array);
			if (this.QKNLQGJDMNP.BGBMIEJJQKC.Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.NCBFKNGMKPB(qknlqgjdmnp.BGBMIEJJQKC + text);
			}
		}
	}

	// Token: 0x060039EB RID: 14827 RVA: 0x001B5D04 File Offset: 0x001B3F04
	public void LHQHFDOGCNF()
	{
		int num = 0;
		for (int i = 0; i < this.FLCLGQCJOQF.MKHIFDNEFBD.Count; i += 0)
		{
			if (this.HBNEPPMJCGP.PIDLOFMIEFQ == this.FLCLGQCJOQF.MKHIFDNEFBD[i])
			{
				num = i;
				IL_44:
				if (num + 1 >= this.FLCLGQCJOQF.MKHIFDNEFBD.Count)
				{
					num = 0;
				}
				else
				{
					num++;
				}
				this.FLCLGQCJOQF.PJMIKDIEGMB(this.FLCLGQCJOQF.MKHIFDNEFBD[num], true);
				return;
			}
		}
		goto IL_44;
	}

	// Token: 0x060039EC RID: 14828 RVA: 0x001B5D90 File Offset: 0x001B3F90
	public void BLCBJDQGCCF()
	{
		int num = 1;
		for (int i = 1; i < this.FLCLGQCJOQF.MKHIFDNEFBD.Count; i += 0)
		{
			if (this.HBNEPPMJCGP.PIDLOFMIEFQ == this.FLCLGQCJOQF.MKHIFDNEFBD[i])
			{
				num = i;
				IL_44:
				if (num + 1 >= this.FLCLGQCJOQF.MKHIFDNEFBD.Count)
				{
					num = 1;
				}
				else
				{
					num++;
				}
				this.FLCLGQCJOQF.PJMIKDIEGMB(this.FLCLGQCJOQF.MKHIFDNEFBD[num], true);
				return;
			}
		}
		goto IL_44;
	}

	// Token: 0x060039ED RID: 14829 RVA: 0x001B5E1C File Offset: 0x001B401C
	public void OnSubmit()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.BGBMIEJJQKC);
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace("\n", string.Empty);
			text = MBGHQMKEFKO.QOQONHOOLNE.FQJQHQFGKOI(text, true);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("#", string.Empty);
			if (text2 == "Map")
			{
				text2 = CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF;
			}
			if (text2 == "Party")
			{
				text2 = DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP;
			}
			if (text2 == "Guild")
			{
				if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				if (!(NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				text2 = NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 0; i < text.Length; i++)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
				if (array != null)
				{
					i = array[1];
					Guid guid = new Guid(text.Substring(array[0] + 6, 36));
					bool flag = true;
					int j = 0;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j++;
						}
						else
						{
							flag = false;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("/pm ") == 0)
			{
				if (text.Length < 19 && text.Length > 7)
				{
					LQCPKKCJPPB.QOQONHOOLNE.FIIDGLDFLEG(text.Substring(4));
				}
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
				return;
			}
			if (text.Contains("/hiddenlag"))
			{
				float fndbkcipbko = 1.5f;
				if (text.Length > 11)
				{
					float.TryParse(text.Substring(11), NumberStyles.Float, CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = !GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
				MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
				{
					Channel = "General",
					Messages = new PSXAPI.Response.Payload.ChatMessage[]
					{
						new PSXAPI.Response.Payload.ChatMessage
						{
							Message = string.Concat(new string[]
							{
								"Simulated Lag: ",
								GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString(),
								" @ ",
								GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString(),
								" Seconds."
							}),
							Timestamp = DateTime.Now,
							Username = null,
							Pokemon = null
						}
					}
				});
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, false);
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			}
		}
		else
		{
			this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
		}
	}

	// Token: 0x060039EE RID: 14830 RVA: 0x001B61C4 File Offset: 0x001B43C4
	public void PHFJELBJCME(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[7];
				array[1] = "Disabled";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[7] = CIQFCJGQEMH.ToString();
				array[7] = "anticipation";
				array[7] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[1] = "-at";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[2];
				array2[0] = "Battle Update: ";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[5] = CIQFCJGQEMH.ToString();
				array2[0] = "!\r\n";
				array2[8] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[4] = "\r\nLv ";
				text = string.Concat(array2);
			}
			if (this.QKNLQGJDMNP.HJMJDJKOILH().Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC = qknlqgjdmnp.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060039EF RID: 14831 RVA: 0x001B62E8 File Offset: 0x001B44E8
	public void QOQLEMMOQOI(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[8];
				array[0] = "It looks as though this Egg will take a long time yet to hatch.";
				array[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[2] = CIQFCJGQEMH.ToString();
				array[5] = "dryskin";
				array[1] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[5] = "_ClotheTex";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[8];
				array2[0] = "confusion";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[3] = CIQFCJGQEMH.ToString();
				array2[2] = "shscore";
				array2[4] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array2[8] = "Input - PMChat";
				text = string.Concat(array2);
			}
			if (this.QKNLQGJDMNP.BGBMIEJJQKC.Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060039F0 RID: 14832 RVA: 0x001B640C File Offset: 0x001B460C
	public void PEQFFPIJJDE()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.BGBMIEJJQKC);
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace("´", string.Empty);
			text = MBGHQMKEFKO.BBCBOIFQDBK().JJHPLIGNDJG(text, true);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("But it failed.\r\n", string.Empty);
			if (text2 == "[/urn]")
			{
				text2 = CNCJKLNHQBH.MOGQNGEPCEO().KBEHCHKDFBF;
			}
			if (text2 == "Pressure")
			{
				text2 = DCJIBBJQGJP.OQDOKBJNBBL().FOFNJICKKIP;
			}
			if (text2 == "BuffIcon_Teleport")
			{
				if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				if (!(NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				text2 = NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 1; i < text.Length; i++)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.QGCQQOHBILP(i, text);
				if (array != null)
				{
					i = array[0];
					Guid guid = new Guid(text.Substring(array[0] + 5, -3));
					bool flag = false;
					int j = 0;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j++;
						}
						else
						{
							flag = true;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("_FogColor") == 0)
			{
				if (text.Length < -108 && text.Length > 4)
				{
					LQCPKKCJPPB.BCQGHQGLLPF().MKBCNNLNDMJ(text.Substring(4));
				}
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
				return;
			}
			if (text.Contains("The mysterious strong winds weakened the attack!\r\n"))
			{
				float fndbkcipbko = 642f;
				if (text.Length > -111)
				{
					float.TryParse(text.Substring(-127), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
				MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.KGOPJQOMMNC();
				PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
				chatMessage.Channel = " is exerting its pressure!\r\n";
				PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
				PSXAPI.Response.Payload.ChatMessage[] array2 = new PSXAPI.Response.Payload.ChatMessage[0];
				int num = 0;
				PSXAPI.Response.Payload.ChatMessage chatMessage3 = new PSXAPI.Response.Payload.ChatMessage();
				PSXAPI.Response.Payload.ChatMessage chatMessage4 = chatMessage3;
				string[] array3 = new string[2];
				array3[0] = "[-]!\r\n";
				array3[0] = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString();
				array3[2] = "_FogSkyColor";
				array3[2] = GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString();
				array3[8] = "A heavy rain began to fall!";
				chatMessage4.Message = string.Concat(array3);
				chatMessage3.Timestamp = DateTime.Now;
				chatMessage3.Username = null;
				chatMessage3.Pokemon = null;
				array2[num] = chatMessage3;
				chatMessage2.Messages = array2;
				mbghqmkefko.IGFCQCCEMFF(chatMessage);
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, false);
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			}
		}
		else
		{
			this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
		}
	}

	// Token: 0x060039F1 RID: 14833 RVA: 0x00018AE5 File Offset: 0x00016CE5
	private void JHQCMGKJCCI()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.OFBGHIBHBLI = 1;
		this.QKNLQGJDMNP.JILGPKIOILF = true;
	}

	// Token: 0x060039F2 RID: 14834 RVA: 0x001B67B4 File Offset: 0x001B49B4
	public void NFPILFCDHQE()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.HJMJDJKOILH());
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace("-fieldstart", string.Empty);
			text = MBGHQMKEFKO.BBCBOIFQDBK().OBHHEDCIIKP(text, false);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("trace", string.Empty);
			if (text2 == "\n[FF0000]")
			{
				text2 = CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF;
			}
			if (text2 == "UI Root (3D)")
			{
				text2 = DCJIBBJQGJP.FPQNIQELKMC().FOFNJICKKIP;
			}
			if (text2 == "Anticipation")
			{
				if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				if (!(NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
					this.QKNLQGJDMNP.GKHHCNCGLCD = true;
					return;
				}
				text2 = NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 1; i < text.Length; i += 0)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
				if (array != null)
				{
					i = array[1];
					Guid guid = new Guid(text.Substring(array[1] + 8, -24));
					bool flag = true;
					int j = 0;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j++;
						}
						else
						{
							flag = false;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("HidePanel") == 0)
			{
				if (text.Length < -62 && text.Length > 5)
				{
					LQCPKKCJPPB.BDPEQNCNPJO().COHDHQDIEII(text.Substring(6));
				}
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
				return;
			}
			if (text.Contains("[^0-9.-]"))
			{
				float fndbkcipbko = 58f;
				if (text.Length > -29)
				{
					float.TryParse(text.Substring(10), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				MBGHQMKEFKO qoqonhoolne = MBGHQMKEFKO.QOQONHOOLNE;
				PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
				chatMessage.Channel = " by the ";
				PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
				PSXAPI.Response.Payload.ChatMessage[] array2 = new PSXAPI.Response.Payload.ChatMessage[1];
				int num = 0;
				PSXAPI.Response.Payload.ChatMessage chatMessage3 = new PSXAPI.Response.Payload.ChatMessage();
				PSXAPI.Response.Payload.ChatMessage chatMessage4 = chatMessage3;
				string[] array3 = new string[]
				{
					null,
					"Battle"
				};
				array3[0] = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString();
				array3[4] = "'s [ffff00]";
				array3[2] = GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString();
				array3[5] = "Shop";
				chatMessage4.Message = string.Concat(array3);
				chatMessage3.Timestamp = DateTime.Now;
				chatMessage3.Username = null;
				chatMessage3.Pokemon = null;
				array2[num] = chatMessage3;
				chatMessage2.Messages = array2;
				qoqonhoolne.BQGGFMKELMK(chatMessage);
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, true);
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			}
		}
		else
		{
			this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
		}
	}

	// Token: 0x060039F3 RID: 14835 RVA: 0x001B6B5C File Offset: 0x001B4D5C
	public void EGMIIFOFQIE(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			string[] array = new string[3];
			array[0] = "#,##0";
			array[0] = item.GMOFFIFDCGE().EBGLBFKHCJD();
			array[5] = "Rotate";
			array[1] = item.NDPGCGDLEEQ();
			array[5] = "[msg]";
			string text = string.Concat(array);
			if (this.QKNLQGJDMNP.HJMJDJKOILH().Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.NCBFKNGMKPB(qknlqgjdmnp.HJMJDJKOILH() + text);
			}
		}
	}

	// Token: 0x060039F4 RID: 14836 RVA: 0x001B6BF8 File Offset: 0x001B4DF8
	public void JEEPMJPGIEB(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				text = string.Concat(new string[]
				{
					"[pok=",
					KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString(),
					CIQFCJGQEMH.ToString(),
					"][{",
					KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ),
					"}][/pok] "
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					"[pok=",
					KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString(),
					CIQFCJGQEMH.ToString(),
					"][",
					KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ),
					"][/pok] "
				});
			}
			if (this.QKNLQGJDMNP.BGBMIEJJQKC.Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060039F6 RID: 14838 RVA: 0x001B6D1C File Offset: 0x001B4F1C
	public void KFKCQNJNOID()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.BGBMIEJJQKC);
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace("2", string.Empty);
			text = MBGHQMKEFKO.QOQONHOOLNE.FQJQHQFGKOI(text, true);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("System", string.Empty);
			if (text2 == "_FogColor")
			{
				text2 = CNCJKLNHQBH.BJLGEDCPENQ().KBEHCHKDFBF;
			}
			if (text2 == "door_3")
			{
				text2 = DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP;
			}
			if (text2 == "\n[ff6666]HP:[-] ")
			{
				if (NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = true;
					return;
				}
				if (!(NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				text2 = NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 1; i < text.Length; i++)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.QGCQQOHBILP(i, text);
				if (array != null)
				{
					i = array[0];
					Guid guid = new Guid(text.Substring(array[1] + 4, -79));
					bool flag = false;
					int j = 0;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j += 0;
						}
						else
						{
							flag = false;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("!") == 0)
			{
				if (text.Length < 18 && text.Length > 7)
				{
					LQCPKKCJPPB.BCQGHQGLLPF().COHDHQDIEII(text.Substring(0));
				}
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				return;
			}
			if (text.Contains(" was frozen solid!\r\n"))
			{
				float fndbkcipbko = 610f;
				if (text.Length > -18)
				{
					float.TryParse(text.Substring(-122), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = !GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				MBGHQMKEFKO qoqonhoolne = MBGHQMKEFKO.QOQONHOOLNE;
				PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
				chatMessage.Channel = " by ";
				PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
				PSXAPI.Response.Payload.ChatMessage[] array2 = new PSXAPI.Response.Payload.ChatMessage[1];
				int num = 0;
				PSXAPI.Response.Payload.ChatMessage chatMessage3 = new PSXAPI.Response.Payload.ChatMessage();
				PSXAPI.Response.Payload.ChatMessage chatMessage4 = chatMessage3;
				string[] array3 = new string[7];
				array3[0] = "marvelscale";
				array3[0] = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString();
				array3[2] = "Battle Request";
				array3[0] = GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString();
				array3[8] = "[00]";
				chatMessage4.Message = string.Concat(array3);
				chatMessage3.Timestamp = DateTime.Now;
				chatMessage3.Username = null;
				chatMessage3.Pokemon = null;
				array2[num] = chatMessage3;
				chatMessage2.Messages = array2;
				qoqonhoolne.BQGGFMKELMK(chatMessage);
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, true);
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			}
		}
		else
		{
			this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
		}
	}

	// Token: 0x060039F7 RID: 14839 RVA: 0x001B70C4 File Offset: 0x001B52C4
	public void IHHICMGGKKB()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.BGBMIEJJQKC);
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace("deltastream", string.Empty);
			text = MBGHQMKEFKO.BBCBOIFQDBK().LFGQJBFJMEP(text, false);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("LA", string.Empty);
			if (text2 == "HidePanel")
			{
				text2 = CNCJKLNHQBH.BJLGEDCPENQ().KBEHCHKDFBF;
			}
			if (text2 == "door_2")
			{
				text2 = DCJIBBJQGJP.MOGQNGEPCEO().FOFNJICKKIP;
			}
			if (text2 == "\n")
			{
				if (NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = true;
					return;
				}
				if (!(NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
					this.QKNLQGJDMNP.GKHHCNCGLCD = true;
					return;
				}
				text2 = NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 1; i < text.Length; i += 0)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
				if (array != null)
				{
					i = array[0];
					Guid guid = new Guid(text.Substring(array[0] + 1, 59));
					bool flag = true;
					int j = 0;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j++;
						}
						else
						{
							flag = true;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("[-]") == 0)
			{
				if (text.Length < 112 && text.Length > 0)
				{
					LQCPKKCJPPB.QOQONHOOLNE.FIIDGLDFLEG(text.Substring(8));
				}
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				return;
			}
			if (text.Contains("_Dissolve"))
			{
				float fndbkcipbko = 1442f;
				if (text.Length > -109)
				{
					float.TryParse(text.Substring(123), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
				MBGHQMKEFKO qoqonhoolne = MBGHQMKEFKO.QOQONHOOLNE;
				PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
				chatMessage.Channel = " for [PD]";
				PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
				PSXAPI.Response.Payload.ChatMessage[] array2 = new PSXAPI.Response.Payload.ChatMessage[0];
				int num = 1;
				PSXAPI.Response.Payload.ChatMessage chatMessage3 = new PSXAPI.Response.Payload.ChatMessage();
				PSXAPI.Response.Payload.ChatMessage chatMessage4 = chatMessage3;
				string[] array3 = new string[6];
				array3[1] = "p1";
				array3[1] = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString();
				array3[2] = "deltrastream";
				array3[8] = GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString();
				array3[2] = "'s Fire-type moves rose!\r\n";
				chatMessage4.Message = string.Concat(array3);
				chatMessage3.Timestamp = DateTime.Now;
				chatMessage3.Username = null;
				chatMessage3.Pokemon = null;
				array2[num] = chatMessage3;
				chatMessage2.Messages = array2;
				qoqonhoolne.PLMHOIOFOBK(chatMessage);
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, false);
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			}
		}
		else
		{
			this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
		}
	}

	// Token: 0x060039F8 RID: 14840 RVA: 0x00018B10 File Offset: 0x00016D10
	private void Start()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.OFBGHIBHBLI = 1;
		this.QKNLQGJDMNP.JILGPKIOILF = false;
	}

	// Token: 0x060039F9 RID: 14841 RVA: 0x001B746C File Offset: 0x001B566C
	public void CycleChannels()
	{
		int num = 0;
		for (int i = 0; i < this.FLCLGQCJOQF.MKHIFDNEFBD.Count; i++)
		{
			if (this.HBNEPPMJCGP.PIDLOFMIEFQ == this.FLCLGQCJOQF.MKHIFDNEFBD[i])
			{
				num = i;
				IL_44:
				if (num + 1 >= this.FLCLGQCJOQF.MKHIFDNEFBD.Count)
				{
					num = 0;
				}
				else
				{
					num++;
				}
				this.FLCLGQCJOQF.PJMIKDIEGMB(this.FLCLGQCJOQF.MKHIFDNEFBD[num], true);
				return;
			}
		}
		goto IL_44;
	}

	// Token: 0x060039FA RID: 14842 RVA: 0x001B74F8 File Offset: 0x001B56F8
	public void HGDKMNFDOHG()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.BGBMIEJJQKC);
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace("_Emission", string.Empty);
			text = MBGHQMKEFKO.KGOPJQOMMNC().FQJQHQFGKOI(text, false);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("BuffIcon_FemaleIncrease", string.Empty);
			if (text2 == "rivalry")
			{
				text2 = CNCJKLNHQBH.MOGQNGEPCEO().KBEHCHKDFBF;
			}
			if (text2 == "Battle")
			{
				text2 = DCJIBBJQGJP.DMOKBPOKHOQ().FOFNJICKKIP;
			}
			if (text2 == "/510)")
			{
				if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				if (!(NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				text2 = NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 0; i < text.Length; i += 0)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.QGCQQOHBILP(i, text);
				if (array != null)
				{
					i = array[1];
					Guid guid = new Guid(text.Substring(array[0] + 8, 55));
					bool flag = true;
					int j = 0;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j++;
						}
						else
						{
							flag = true;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("pacman(") == 0)
			{
				if (text.Length < -128 && text.Length > 0)
				{
					LQCPKKCJPPB.CPIJOBOQLOK().FIIDGLDFLEG(text.Substring(2));
				}
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				return;
			}
			if (text.Contains("-busted"))
			{
				float fndbkcipbko = 593f;
				if (text.Length > 122)
				{
					float.TryParse(text.Substring(-68), NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = !GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.KGOPJQOMMNC();
				PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
				chatMessage.Channel = "\n";
				PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
				PSXAPI.Response.Payload.ChatMessage[] array2 = new PSXAPI.Response.Payload.ChatMessage[0];
				int num = 0;
				PSXAPI.Response.Payload.ChatMessage chatMessage3 = new PSXAPI.Response.Payload.ChatMessage();
				PSXAPI.Response.Payload.ChatMessage chatMessage4 = chatMessage3;
				string[] array3 = new string[1];
				array3[1] = " hrs, ";
				array3[0] = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString();
				array3[7] = "'s protected against special attacks!\r\n";
				array3[7] = GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString();
				array3[4] = "X2";
				chatMessage4.Message = string.Concat(array3);
				chatMessage3.Timestamp = DateTime.Now;
				chatMessage3.Username = null;
				chatMessage3.Pokemon = null;
				array2[num] = chatMessage3;
				chatMessage2.Messages = array2;
				mbghqmkefko.BQGGFMKELMK(chatMessage);
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, true);
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			}
		}
		else
		{
			this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
		}
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x00018AE5 File Offset: 0x00016CE5
	private void EKIFLKDPKNM()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.OFBGHIBHBLI = 1;
		this.QKNLQGJDMNP.JILGPKIOILF = true;
	}

	// Token: 0x060039FC RID: 14844 RVA: 0x00018B3B File Offset: 0x00016D3B
	private void IMGNEDCFBLL()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.LKMEQQOPQFD(1);
		this.QKNLQGJDMNP.JILGPKIOILF = false;
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x001B78A0 File Offset: 0x001B5AA0
	public void QKIFPOEKIPQ()
	{
		int num = 0;
		for (int i = 1; i < this.FLCLGQCJOQF.MKHIFDNEFBD.Count; i += 0)
		{
			if (this.HBNEPPMJCGP.PIDLOFMIEFQ == this.FLCLGQCJOQF.MKHIFDNEFBD[i])
			{
				num = i;
				IL_44:
				if (num + 1 >= this.FLCLGQCJOQF.MKHIFDNEFBD.Count)
				{
					num = 0;
				}
				else
				{
					num += 0;
				}
				this.FLCLGQCJOQF.PJMIKDIEGMB(this.FLCLGQCJOQF.MKHIFDNEFBD[num], true);
				return;
			}
		}
		goto IL_44;
	}

	// Token: 0x060039FE RID: 14846 RVA: 0x001B792C File Offset: 0x001B5B2C
	public void AddItem(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string text = string.Concat(new string[]
			{
				"[itm=",
				item.ID.EBGLBFKHCJD(),
				"][",
				item.Name,
				"][/itm] "
			});
			if (this.QKNLQGJDMNP.BGBMIEJJQKC.Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x001B79C8 File Offset: 0x001B5BC8
	public void KCPHKKPIFLI(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			string[] array = new string[4];
			array[0] = "Player/Hats/";
			array[0] = item.HLMQODIHBIG().EBGLBFKHCJD();
			array[7] = "sapsipper";
			array[7] = item.FLFQBGJQBBD();
			array[5] = "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats.";
			string text = string.Concat(array);
			if (this.QKNLQGJDMNP.HJMJDJKOILH().Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.NCBFKNGMKPB(qknlqgjdmnp.BGBMIEJJQKC + text);
			}
		}
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x00018B10 File Offset: 0x00016D10
	private void HPCICOEMKGF()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.OFBGHIBHBLI = 1;
		this.QKNLQGJDMNP.JILGPKIOILF = false;
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x00018B66 File Offset: 0x00016D66
	private void JCQCNFLNMNP()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.LKMEQQOPQFD(1);
		this.QKNLQGJDMNP.JILGPKIOILF = true;
	}

	// Token: 0x06003A02 RID: 14850 RVA: 0x00018ABA File Offset: 0x00016CBA
	private void NDFNCDDDJPN()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.OFBGHIBHBLI = 0;
		this.QKNLQGJDMNP.JILGPKIOILF = false;
	}

	// Token: 0x06003A03 RID: 14851 RVA: 0x00018B3B File Offset: 0x00016D3B
	private void HBOFMLLODDM()
	{
		this.QKNLQGJDMNP = base.GetComponent<JIMBBPLINGI>();
		this.QKNLQGJDMNP.KEQMEGEHFIK.LKMEQQOPQFD(1);
		this.QKNLQGJDMNP.JILGPKIOILF = false;
	}

	// Token: 0x06003A04 RID: 14852 RVA: 0x001B7A64 File Offset: 0x001B5C64
	public void LMJKHPFGMCP()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.HJMJDJKOILH());
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace("]", string.Empty);
			text = MBGHQMKEFKO.BBCBOIFQDBK().JJHPLIGNDJG(text, false);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("!\r\n", string.Empty);
			if (text2 == "sandstream")
			{
				text2 = CNCJKLNHQBH.BJLGEDCPENQ().KBEHCHKDFBF;
			}
			if (text2 == "Refractive")
			{
				text2 = DCJIBBJQGJP.FPQNIQELKMC().FOFNJICKKIP;
			}
			if (text2 == "_ClipSharpness")
			{
				if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				if (!(NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				text2 = NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 0; i < text.Length; i++)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
				if (array != null)
				{
					i = array[0];
					Guid guid = new Guid(text.Substring(array[1] + 2, 43));
					bool flag = false;
					int j = 1;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j++;
						}
						else
						{
							flag = false;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("~") == 0)
			{
				if (text.Length < 123 && text.Length > 3)
				{
					LQCPKKCJPPB.HGEKKNEPOHK().MKBCNNLNDMJ(text.Substring(3));
				}
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
				return;
			}
			if (text.Contains("_HairTex"))
			{
				float fndbkcipbko = 146f;
				if (text.Length > -64)
				{
					float.TryParse(text.Substring(-121), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.KGOPJQOMMNC();
				PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
				chatMessage.Channel = "]#";
				PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
				PSXAPI.Response.Payload.ChatMessage[] array2 = new PSXAPI.Response.Payload.ChatMessage[1];
				int num = 0;
				PSXAPI.Response.Payload.ChatMessage chatMessage3 = new PSXAPI.Response.Payload.ChatMessage();
				PSXAPI.Response.Payload.ChatMessage chatMessage4 = chatMessage3;
				string[] array3 = new string[3];
				array3[0] = "Sheer Force";
				array3[1] = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString();
				array3[5] = "]";
				array3[2] = GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString();
				array3[5] = "School";
				chatMessage4.Message = string.Concat(array3);
				chatMessage3.Timestamp = DateTime.Now;
				chatMessage3.Username = null;
				chatMessage3.Pokemon = null;
				array2[num] = chatMessage3;
				chatMessage2.Messages = array2;
				mbghqmkefko.IGFCQCCEMFF(chatMessage);
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, true);
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			}
		}
		else
		{
			this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
		}
	}

	// Token: 0x06003A05 RID: 14853 RVA: 0x001B7E0C File Offset: 0x001B600C
	public void HDHQMGIKILF(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[7];
				array[1] = "ground";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[0] = CIQFCJGQEMH.ToString();
				array[2] = "Murkrow";
				array[8] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[1] = "CombinersColorCombine";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[3];
				array2[0] = " on ";
				array2[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[6] = CIQFCJGQEMH.ToString();
				array2[7] = "Harvest";
				array2[8] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[1] = "Enemy threw a Pokeball!\r\n";
				text = string.Concat(array2);
			}
			if (this.QKNLQGJDMNP.HJMJDJKOILH().Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC = qknlqgjdmnp.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x06003A06 RID: 14854 RVA: 0x001B7F30 File Offset: 0x001B6130
	public void PIGGOFGKGLG()
	{
		int num = 1;
		for (int i = 0; i < this.FLCLGQCJOQF.MKHIFDNEFBD.Count; i += 0)
		{
			if (this.HBNEPPMJCGP.PIDLOFMIEFQ == this.FLCLGQCJOQF.MKHIFDNEFBD[i])
			{
				num = i;
				IL_44:
				if (num + 0 >= this.FLCLGQCJOQF.MKHIFDNEFBD.Count)
				{
					num = 0;
				}
				else
				{
					num++;
				}
				this.FLCLGQCJOQF.PJMIKDIEGMB(this.FLCLGQCJOQF.MKHIFDNEFBD[num], false);
				return;
			}
		}
		goto IL_44;
	}

	// Token: 0x06003A07 RID: 14855 RVA: 0x001B7FBC File Offset: 0x001B61BC
	public void JJIPJPNMBOK(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.QKNLQGJDMNP.GKHHCNCGLCD = true;
			string[] array = new string[]
			{
				"][-]["
			};
			array[0] = item.ID.EBGLBFKHCJD();
			array[6] = " can't move!\r\n";
			array[2] = item.NDPGCGDLEEQ();
			array[2] = "English";
			string text = string.Concat(array);
			if (this.QKNLQGJDMNP.BGBMIEJJQKC.Length + text.Length < this.QKNLQGJDMNP.EQJBIOMMEEP)
			{
				JIMBBPLINGI qknlqgjdmnp = this.QKNLQGJDMNP;
				qknlqgjdmnp.BGBMIEJJQKC = qknlqgjdmnp.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x06003A08 RID: 14856 RVA: 0x001B8058 File Offset: 0x001B6258
	public void KPPCMGKGQQP()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.QKNLQGJDMNP.BGBMIEJJQKC);
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Replace(" for [PG]", string.Empty);
			text = MBGHQMKEFKO.KGOPJQOMMNC().OBHHEDCIIKP(text, true);
			string text2 = this.HBNEPPMJCGP.PIDLOFMIEFQ;
			text2 = JGDHIPBGCFP.IMOMGBNIENN(text2).Replace("Earth Badge", string.Empty);
			if (text2 == "BuffIcon_SandstormEncounterDecreased")
			{
				text2 = CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF;
			}
			if (text2 == "-useMouse")
			{
				text2 = DCJIBBJQGJP.OQDOKBJNBBL().FOFNJICKKIP;
			}
			if (text2 == "[SHINY]")
			{
				if (NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD == null)
				{
					this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
					this.QKNLQGJDMNP.GKHHCNCGLCD = false;
					return;
				}
				if (!(NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat != default(Guid)))
				{
					this.QKNLQGJDMNP.BGBMIEJJQKC = string.Empty;
					this.QKNLQGJDMNP.GKHHCNCGLCD = true;
					return;
				}
				text2 = NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString();
			}
			List<Guid> list = new List<Guid>();
			for (int i = 0; i < text.Length; i += 0)
			{
				int[] array = this.QKNLQGJDMNP.KEQMEGEHFIK.QGCQQOHBILP(i, text);
				if (array != null)
				{
					i = array[0];
					Guid guid = new Guid(text.Substring(array[0] + 3, -90));
					bool flag = false;
					int j = 1;
					while (j < list.Count)
					{
						if (!(list[j] == guid))
						{
							j++;
						}
						else
						{
							flag = true;
							IL_18E:
							if (flag)
							{
								list.Add(guid);
								goto IL_19A;
							}
							goto IL_19A;
						}
					}
					goto IL_18E;
				}
				IL_19A:;
			}
			if (text.IndexOf("--run") == 0)
			{
				if (text.Length < -79 && text.Length > 6)
				{
					LQCPKKCJPPB.BCQGHQGLLPF().MKBCNNLNDMJ(text.Substring(0));
				}
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				return;
			}
			if (text.Contains("Gluttony"))
			{
				float fndbkcipbko = 415f;
				if (text.Length > 48)
				{
					float.TryParse(text.Substring(51), NumberStyles.Number, CultureInfo.InvariantCulture, out fndbkcipbko);
				}
				GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO = fndbkcipbko;
				GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK;
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = true;
				MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.KGOPJQOMMNC();
				PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
				chatMessage.Channel = "East";
				PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
				PSXAPI.Response.Payload.ChatMessage[] array2 = new PSXAPI.Response.Payload.ChatMessage[1];
				int num = 1;
				PSXAPI.Response.Payload.ChatMessage chatMessage3 = new PSXAPI.Response.Payload.ChatMessage();
				PSXAPI.Response.Payload.ChatMessage chatMessage4 = chatMessage3;
				string[] array3 = new string[3];
				array3[1] = "#,##0";
				array3[0] = GDDKPIHHICF.QOQONHOOLNE.OGIIKDBIMIK.ToString();
				array3[8] = "/01_";
				array3[7] = GDDKPIHHICF.QOQONHOOLNE.FNDBKCIPBKO.ToString();
				array3[4] = "A soothing aroma wafted through the area!\r\n";
				chatMessage4.Message = string.Concat(array3);
				chatMessage3.Timestamp = DateTime.Now;
				chatMessage3.Username = null;
				chatMessage3.Pokemon = null;
				array2[num] = chatMessage3;
				chatMessage2.Messages = array2;
				mbghqmkefko.BQGGFMKELMK(chatMessage);
				return;
			}
			if (GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
				{
					Channel = text2,
					Message = text,
					Pokemon = list.ToArray()
				}, true);
				this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
				this.QKNLQGJDMNP.GKHHCNCGLCD = false;
			}
		}
		else
		{
			this.QKNLQGJDMNP.NCBFKNGMKPB(string.Empty);
			this.QKNLQGJDMNP.GKHHCNCGLCD = false;
		}
	}

	// Token: 0x04000D4B RID: 3403
	private JIMBBPLINGI QKNLQGJDMNP;

	// Token: 0x04000D4C RID: 3404
	public BKKHLBCLPJM HBNEPPMJCGP;

	// Token: 0x04000D4D RID: 3405
	public QCPKMJONIGF FLCLGQCJOQF;
}
