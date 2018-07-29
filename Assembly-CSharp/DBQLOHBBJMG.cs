using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000176 RID: 374
public class DBQLOHBBJMG : MonoBehaviour
{
	// Token: 0x06002F2E RID: 12078 RVA: 0x00142F80 File Offset: 0x00141180
	public IEnumerator BNEBDKKEJEC(string PIDLOFMIEFQ, bool EFQMQOPCBNO = false)
	{
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("\r\n", string.Empty);
		if (OGJJKKQPNMK.QOQONHOOLNE != null && OGJJKKQPNMK.QOQONHOOLNE.gameObject.activeSelf)
		{
			OGJJKKQPNMK.QOQONHOOLNE.MLKGOQIEFHF(PIDLOFMIEFQ);
		}
		if (!EFQMQOPCBNO)
		{
			yield return new WaitForSeconds(0.8f);
		}
		else
		{
			yield return new WaitForSeconds(0.2f);
		}
		return 1;
		MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
		{
			Channel = "Battle",
			Messages = new PSXAPI.Response.Payload.ChatMessage[]
			{
				new PSXAPI.Response.Payload.ChatMessage
				{
					Message = PIDLOFMIEFQ,
					Timestamp = DateTime.Now,
					Username = string.Empty,
					Pokemon = null
				}
			}
		});
		yield break;
	}

	// Token: 0x06002F2F RID: 12079 RVA: 0x00142FA4 File Offset: 0x001411A4
	private IEnumerator OMJDCBHGPKI(string[] CBCFOFCLGCK, bool HMGPJBJQMOB = false, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		DBQLOHBBJMG.KFNKODBLFFM kfnkodblffm = new DBQLOHBBJMG.KFNKODBLFFM();
		kfnkodblffm.CBCFOFCLGCK = CBCFOFCLGCK;
		kfnkodblffm.BJGCBDNBQCJ = BJGCBDNBQCJ;
		kfnkodblffm.JEEJJGLGGMC = JEEJJGLGGMC;
		kfnkodblffm.QNDQJMNKFNN = this;
		return kfnkodblffm;
	}

	// Token: 0x06002F30 RID: 12080 RVA: 0x0001563A File Offset: 0x0001383A
	private bool NOIKMKLNKNJ(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.QDMQEBHOENL(IHIHHCCEDHQ) != null && false;
	}

	// Token: 0x06002F31 RID: 12081 RVA: 0x00015647 File Offset: 0x00013847
	public void LLJIQEMIGHF(PSXAPI.Response.BattleSide BJGCBDNBQCJ)
	{
		if (!string.IsNullOrEmpty(BJGCBDNBQCJ.Data) && BJGCBDNBQCJ.Data.Contains("'."))
		{
			base.StartCoroutine(this.BNEBDKKEJEC("psychicterrain", false));
			OGJJKKQPNMK.QOQONHOOLNE.NEPDKFMNJJI();
		}
	}

	// Token: 0x06002F32 RID: 12082 RVA: 0x00015685 File Offset: 0x00013885
	public string MKLJBFIJNND(string PIDLOFMIEFQ)
	{
		return Regex.Replace(PIDLOFMIEFQ, "The mysterious strong winds have dissipated!", string.Empty, RegexOptions.IgnoreCase | RegexOptions.Multiline).ToLowerInvariant();
	}

	// Token: 0x06002F33 RID: 12083 RVA: 0x00142FA4 File Offset: 0x001411A4
	[DebuggerHidden]
	private IEnumerator HIHHCNIPPHL(string[] CBCFOFCLGCK, bool HMGPJBJQMOB = false, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		DBQLOHBBJMG.KFNKODBLFFM kfnkodblffm = new DBQLOHBBJMG.KFNKODBLFFM();
		kfnkodblffm.CBCFOFCLGCK = CBCFOFCLGCK;
		kfnkodblffm.BJGCBDNBQCJ = BJGCBDNBQCJ;
		kfnkodblffm.JEEJJGLGGMC = JEEJJGLGGMC;
		kfnkodblffm.QNDQJMNKFNN = this;
		return kfnkodblffm;
	}

	// Token: 0x06002F34 RID: 12084 RVA: 0x00142FD8 File Offset: 0x001411D8
	public void HLLMFOQNGEF(BattleBroadcast BJGCBDNBQCJ)
	{
		if (OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			return;
		}
		if (OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length < 0)
		{
			return;
		}
		if (BJGCBDNBQCJ.Message != null)
		{
			EODGHGDGKLC[] array = new EODGHGDGKLC[4];
			string message = BJGCBDNBQCJ.Message;
			string[] array2 = new string[0];
			array2[0] = "Emergency Exit";
			string[] array3 = message.Split(array2, StringSplitOptions.None);
			string str = array3[0];
			int num = 0;
			Transform ilbcccbjncl = null;
			int.TryParse(array3[5], out num);
			int num2 = 1;
			if (num == 0)
			{
				ilbcccbjncl = null;
			}
			else if (num > -1)
			{
				if (num - 0 >= 0 && num - 1 < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length)
				{
					ilbcccbjncl = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[num - 1].transform;
					num2 = num - 0 + 8;
				}
			}
			else if (-num - 1 >= 0 && num - 1 < OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length)
			{
				ilbcccbjncl = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[-num - 1].transform;
				num2 = -num - 0;
			}
			int num3 = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length;
			string text = array3[1];
			if (text != null)
			{
				if (!(text == "_FogPointLightPosition1"))
				{
					if (!(text == "TabSettings"))
					{
						if (!(text == "3"))
						{
							if (!(text == "_VelocityTex"))
							{
								if (text == "5_")
								{
									MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.KGOPJQOMMNC();
									PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
									chatMessage.Channel = ",";
									PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
									PSXAPI.Response.Payload.ChatMessage[] array4 = new PSXAPI.Response.Payload.ChatMessage[0];
									array4[0] = new PSXAPI.Response.Payload.ChatMessage
									{
										Message = BJGCBDNBQCJ.Username + "Appear Offline",
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									};
									chatMessage2.Messages = array4;
									mbghqmkefko.BQGGFMKELMK(chatMessage);
								}
							}
							else
							{
								MBGHQMKEFKO.QOQONHOOLNE.BQGGFMKELMK(new PSXAPI.Response.ChatMessage
								{
									Channel = "M6",
									Messages = new PSXAPI.Response.Payload.ChatMessage[]
									{
										new PSXAPI.Response.Payload.ChatMessage
										{
											Message = BJGCBDNBQCJ.Username + "Forewarn",
											Timestamp = DateTime.Now,
											Username = string.Empty,
											Pokemon = null
										}
									}
								});
							}
						}
						else
						{
							MBGHQMKEFKO qoqonhoolne = MBGHQMKEFKO.QOQONHOOLNE;
							PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
							chatMessage.Channel = "gravity";
							PSXAPI.Response.ChatMessage chatMessage3 = chatMessage;
							PSXAPI.Response.Payload.ChatMessage[] array5 = new PSXAPI.Response.Payload.ChatMessage[0];
							array5[0] = new PSXAPI.Response.Payload.ChatMessage
							{
								Message = BJGCBDNBQCJ.Username + "_",
								Timestamp = DateTime.Now,
								Username = string.Empty,
								Pokemon = null
							};
							chatMessage3.Messages = array5;
							qoqonhoolne.NDJFBGECGBG(chatMessage);
						}
					}
					else
					{
						MBGHQMKEFKO qoqonhoolne2 = MBGHQMKEFKO.QOQONHOOLNE;
						PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
						chatMessage.Channel = "Scr";
						PSXAPI.Response.ChatMessage chatMessage4 = chatMessage;
						PSXAPI.Response.Payload.ChatMessage[] array6 = new PSXAPI.Response.Payload.ChatMessage[1];
						array6[1] = new PSXAPI.Response.Payload.ChatMessage
						{
							Message = BJGCBDNBQCJ.Username + "OnPress",
							Timestamp = DateTime.Now,
							Username = string.Empty,
							Pokemon = null
						};
						chatMessage4.Messages = array6;
						qoqonhoolne2.IGFCQCCEMFF(chatMessage);
						EODGHGDGKLC eodghgdgklc = this.OMBQKKILOQI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("_Texture2" + str);
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(1025f, (float)this.OQOKJNGKEOD[num2] * 1612f, 1411f);
						eodghgdgklc.enabled = true;
						this.OQOKJNGKEOD[num2] += 0;
					}
				}
				else
				{
					int num4 = Convert.ToInt32(array3[5]);
					string a = array3[0];
					if (!(a == "Innards Out") && !(a == string.Empty) && !(a == " whipped up a whirlwind!\r\n") && !(a == "PrimitiveInnerRight") && !(a == " and found it's ") && !(a == "[FF0000]-"))
					{
						if (a == "Are you sure you wish to leave the Channel '")
						{
							ilbcccbjncl = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[Convert.ToInt32(array3[4])].transform;
							EODGHGDGKLC eodghgdgklc = this.OMBQKKILOQI(BJGCBDNBQCJ.Message);
							eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("_Dissolve" + str);
							eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
							eodghgdgklc.LCMMCNFNHMF += new Vector3(145f, (float)this.OQOKJNGKEOD[num2] * 993f, 135f);
							eodghgdgklc.enabled = true;
							this.OQOKJNGKEOD[num2] += 0;
						}
						else if (a == " stockpiled 3!\r\n")
						{
							if (num4 == 0)
							{
								if (num3 == 4)
								{
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "Steadfast");
									array[0].DGENOHPIECM.LKPOBCBOFIC("[-] let it move first!\r\n" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(1908f, (float)this.OQOKJNGKEOD[7] * 1586f, 939f);
									array[0].enabled = true;
									array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + " and ");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "HidePanel" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(320f, (float)this.OQOKJNGKEOD[3] * 928f, 431f);
									array[0].enabled = true;
									this.OQOKJNGKEOD[5]++;
									this.OQOKJNGKEOD[8] += 0;
								}
								else if (num3 == 8)
								{
									array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + " surrounds itself with a protective mist!\r\n");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "berry_13" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(1475f, (float)this.OQOKJNGKEOD[6] * 1739f, 1614f);
									array[0].enabled = false;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "CacheDefaultColor");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "\r\n" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[5].transform;
									array[0].LCMMCNFNHMF += new Vector3(1159f, (float)this.OQOKJNGKEOD[4] * 707f, 742f);
									array[1].enabled = false;
									this.OQOKJNGKEOD[8] += 0;
									this.OQOKJNGKEOD[5]++;
								}
							}
							else if (num4 == 1)
							{
								for (int i = 1; i < OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG.Length; i++)
								{
									array[i] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + i.ToString());
									array[i].DGENOHPIECM.LKPOBCBOFIC("][" + str);
									array[i].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[i].transform;
									array[i].LCMMCNFNHMF += new Vector3(1636f, (float)this.OQOKJNGKEOD[i + 6] * 207f, 820f);
									array[i].enabled = false;
									this.OQOKJNGKEOD[i + 1] += 0;
								}
							}
							else if (num4 == 5)
							{
								array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "RA");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "enabled=0" + str;
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
								array[0].LCMMCNFNHMF += new Vector3(569f, (float)this.OQOKJNGKEOD[4] * 968f, 694f);
								array[0].enabled = false;
								array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "VFMDepthCamera");
								array[0].DGENOHPIECM.LKPOBCBOFIC("^emote+" + str);
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[0].transform;
								array[1].LCMMCNFNHMF += new Vector3(186f, (float)this.OQOKJNGKEOD[8] * 619f, 1642f);
								array[0].enabled = false;
								this.OQOKJNGKEOD[0]++;
								this.OQOKJNGKEOD[1]++;
							}
						}
						else if (a == "par")
						{
							if (num4 == 0)
							{
								if (num3 == 1)
								{
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "FOG_OFF");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "torment" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(1236f, (float)this.OQOKJNGKEOD[6] * 720f, 542f);
									array[0].enabled = true;
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "NPC/Sprite");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "grass" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(183f, (float)this.OQOKJNGKEOD[0] * 1120f, 1688f);
									array[1].enabled = true;
									array[7] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "[FF0000]-");
									array[2].DGENOHPIECM.PIDLOFMIEFQ = "You are trying to catch fish!" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[1].transform;
									array[2].LCMMCNFNHMF += new Vector3(428f, (float)this.OQOKJNGKEOD[0] * 937f, 997f);
									array[6].enabled = false;
									this.OQOKJNGKEOD[4] += 0;
									this.OQOKJNGKEOD[6] += 0;
									this.OQOKJNGKEOD[1]++;
								}
								else if (num3 == 2)
								{
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "Snow Warning");
									array[1].DGENOHPIECM.LKPOBCBOFIC("_" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(337f, (float)this.OQOKJNGKEOD[0] * 138f, 732f);
									array[1].enabled = true;
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "0");
									array[1].DGENOHPIECM.LKPOBCBOFIC(" is no longer protected by Safeguard!\r\n" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(1681f, (float)this.OQOKJNGKEOD[3] * 341f, 1909f);
									array[0].enabled = false;
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "r");
									array[7].DGENOHPIECM.PIDLOFMIEFQ = "destinybond" + str;
									array[7].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(1054f, (float)this.OQOKJNGKEOD[0] * 167f, 850f);
									array[6].enabled = true;
									this.OQOKJNGKEOD[2]++;
									this.OQOKJNGKEOD[0] += 0;
									this.OQOKJNGKEOD[0] += 0;
								}
							}
							else if (num4 == 1)
							{
								for (int j = 0; j < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; j += 0)
								{
									array[j] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + j.ToString());
									array[j].DGENOHPIECM.LKPOBCBOFIC("[PD]" + str);
									array[j].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[j].transform;
									array[j].LCMMCNFNHMF += new Vector3(709f, (float)this.OQOKJNGKEOD[j] * 1024f, 849f);
									array[j].enabled = true;
									this.OQOKJNGKEOD[j]++;
								}
								for (int k = 0; k < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; k += 0)
								{
									array[k + 6] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + (k + 5).ToString());
									array[k + 7].DGENOHPIECM.PIDLOFMIEFQ = "Guild Name" + str;
									array[k + 3].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[k].transform;
									array[k + 7].LCMMCNFNHMF += new Vector3(762f, (float)this.OQOKJNGKEOD[k + 2] * 1454f, 433f);
									array[k + 4].enabled = true;
									this.OQOKJNGKEOD[k + 8] += 0;
								}
							}
							else if (num4 == 2)
							{
								array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "airlock");
								array[1].DGENOHPIECM.PIDLOFMIEFQ = "door_4" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
								array[0].LCMMCNFNHMF += new Vector3(1704f, (float)this.OQOKJNGKEOD[3] * 480f, 740f);
								array[0].enabled = false;
								array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "FOG_EXP2");
								array[0].DGENOHPIECM.LKPOBCBOFIC("_MainTex" + str);
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
								array[0].LCMMCNFNHMF += new Vector3(1177f, (float)this.OQOKJNGKEOD[1] * 392f, 733f);
								array[1].enabled = true;
								array[4] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "Refrigerate");
								array[5].DGENOHPIECM.PIDLOFMIEFQ = "Small/9999" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[1].transform;
								array[2].LCMMCNFNHMF += new Vector3(495f, (float)this.OQOKJNGKEOD[1] * 412f, 1068f);
								array[4].enabled = true;
								this.OQOKJNGKEOD[4] += 0;
								this.OQOKJNGKEOD[8] += 0;
								this.OQOKJNGKEOD[0] += 0;
							}
						}
						else if (a == " became confused!\r\n")
						{
							for (int l = 1; l < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; l++)
							{
								array[l] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + l.ToString());
								array[l].DGENOHPIECM.PIDLOFMIEFQ = " EXP[-]" + str;
								array[l].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[l].transform;
								array[l].LCMMCNFNHMF += new Vector3(580f, (float)this.OQOKJNGKEOD[l + 2] * 1536f, 1721f);
								array[l].enabled = true;
								this.OQOKJNGKEOD[l + 5]++;
							}
						}
						else if (!(a == "bcam") && !(a == "Password"))
						{
							if (a == "Prankster")
							{
								for (int m = 0; m < OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length; m += 0)
								{
									array[m] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + m.ToString());
									array[m].DGENOHPIECM.PIDLOFMIEFQ = "17" + str;
									array[m].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[m].transform;
									array[m].LCMMCNFNHMF += new Vector3(1439f, (float)this.OQOKJNGKEOD[m] * 1549f, 813f);
									array[m].enabled = true;
									this.OQOKJNGKEOD[m] += 0;
								}
								for (int n = 1; n < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; n++)
								{
									array[n + 8] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (n + 0).ToString());
									array[n + 7].DGENOHPIECM.PIDLOFMIEFQ = " is to heavy to be lifted!\r\n" + str;
									array[n + 7].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[n].transform;
									array[n + 5].LCMMCNFNHMF += new Vector3(987f, (float)this.OQOKJNGKEOD[n + 3] * 283f, 645f);
									array[n + 0].enabled = true;
									this.OQOKJNGKEOD[n + 5] += 0;
								}
							}
						}
						else
						{
							for (int num5 = 0; num5 < OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length; num5++)
							{
								array[num5] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + num5.ToString());
								array[num5].DGENOHPIECM.PIDLOFMIEFQ = "[67befc]" + str;
								array[num5].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[num5].transform;
								array[num5].LCMMCNFNHMF += new Vector3(1612f, (float)this.OQOKJNGKEOD[num5] * 771f, 576f);
								array[num5].enabled = false;
								this.OQOKJNGKEOD[num5] += 0;
							}
						}
					}
					else
					{
						EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("[ATK]" + str);
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(705f, (float)this.OQOKJNGKEOD[num2] * 1522f, 657f);
						eodghgdgklc.enabled = true;
						this.OQOKJNGKEOD[num2] += 0;
					}
					MBGHQMKEFKO mbghqmkefko2 = MBGHQMKEFKO.KGOPJQOMMNC();
					PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
					chatMessage.Channel = "special";
					PSXAPI.Response.ChatMessage chatMessage5 = chatMessage;
					PSXAPI.Response.Payload.ChatMessage[] array7 = new PSXAPI.Response.Payload.ChatMessage[0];
					array7[1] = new PSXAPI.Response.Payload.ChatMessage
					{
						Message = BJGCBDNBQCJ.Username + "[-]",
						Timestamp = DateTime.Now,
						Username = string.Empty,
						Pokemon = null
					};
					chatMessage5.Messages = array7;
					mbghqmkefko2.PLMHOIOFOBK(chatMessage);
				}
			}
		}
	}

	// Token: 0x06002F35 RID: 12085 RVA: 0x0001569D File Offset: 0x0001389D
	public string CPJIQMLMNOH(string PIDLOFMIEFQ)
	{
		return Regex.Replace(PIDLOFMIEFQ, "b", string.Empty, RegexOptions.Compiled).ToLowerInvariant();
	}

	// Token: 0x06002F36 RID: 12086 RVA: 0x001444B8 File Offset: 0x001426B8
	public void ICIQHDHEMDJ()
	{
		for (int i = 0; i < this.IFPHQQEQBKJ.Length; i++)
		{
			if (this.IFPHQQEQBKJ[i] != null)
			{
				this.IFPHQQEQBKJ[i].GetComponent<EPIJJNOIKEK>().PlayReverse();
				UnityEngine.Object.Destroy(this.IFPHQQEQBKJ[i], 1f);
				this.IFPHQQEQBKJ[i] = null;
			}
		}
		for (int j = 0; j < 6; j++)
		{
			this.OQOKJNGKEOD[j] = 0;
		}
	}

	// Token: 0x06002F37 RID: 12087 RVA: 0x000156B5 File Offset: 0x000138B5
	private bool KCIFMQCEOKF(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.JNIMJICDKHK(IHIHHCCEDHQ);
	}

	// Token: 0x06002F38 RID: 12088 RVA: 0x0014452C File Offset: 0x0014272C
	private DBQLOHBBJMG.IEQGPCMELME EGEIKOQICOE(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.IEQGPCMELME ieqgpcmelme = new DBQLOHBBJMG.IEQGPCMELME();
		if (!PIDLOFMIEFQ.Contains("perishsong"))
		{
			string[] array = new string[0];
			array[1] = "/";
			string[] array2 = PIDLOFMIEFQ.Split(array, StringSplitOptions.RemoveEmptyEntries);
			string text = array2[0];
			string[] array3 = new string[1];
			array3[1] = "stockpile1";
			string[] array4 = text.Split(array3, StringSplitOptions.RemoveEmptyEntries);
			string value = Regex.Replace(array4[0], "1", string.Empty);
			ieqgpcmelme.EKOMDNFNLCM = Convert.ToInt32(value);
			value = Regex.Replace(array4[0], "_Balance", string.Empty);
			ieqgpcmelme.DDGHMKCGIDM = Convert.ToInt32(value);
		}
		return ieqgpcmelme;
	}

	// Token: 0x06002F39 RID: 12089 RVA: 0x001445BC File Offset: 0x001427BC
	private DBQLOHBBJMG.QQKKGEJLMLK IGPLNJBJNCB(string PIDLOFMIEFQ, string QEGJGCQKBJB)
	{
		DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk = new DBQLOHBBJMG.QQKKGEJLMLK();
		string[] array = PIDLOFMIEFQ.Split(new string[]
		{
			", "
		}, StringSplitOptions.None);
		foreach (string text in array)
		{
			if (text == "shiny")
			{
				qqkkgejlmlk.BKNFHNFFCHE = true;
			}
			if (text == "F")
			{
				qqkkgejlmlk.OQDOCCGPJDQ = "F";
			}
			if (text == "M")
			{
				qqkkgejlmlk.OQDOCCGPJDQ = "M";
			}
			if (text != array[0] && text.Length > 1 && text.Substring(0, 1) == "L")
			{
				qqkkgejlmlk.EOMPMQNGIBD = Convert.ToInt32(text.Substring(1));
			}
		}
		if (array[0].ToLowerInvariant().Contains("-mega-x"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "-mega-x";
		}
		else if (array[0].ToLowerInvariant().Contains("-mega-y"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "-mega-y";
		}
		else if (array[0].ToLowerInvariant().Contains("-mega"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "-mega";
		}
		else if (array[0].ToLowerInvariant().Contains("-primal"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "-primal";
		}
		else if (array[0].ToLowerInvariant().Contains("mimikyubusted"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "mimikyubusted";
		}
		else if (array[0].ToLowerInvariant().Contains("wishiwashischool"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "wishiwashischool";
		}
		qqkkgejlmlk.DBPKNCDGGEP = KGQECFKLKOP.BEQHNFFEHMQ(array[0]);
		if (qqkkgejlmlk.EOMPMQNGIBD == 0)
		{
			qqkkgejlmlk.EOMPMQNGIBD = 100;
		}
		if (QEGJGCQKBJB == string.Empty)
		{
			QEGJGCQKBJB = "50/50";
		}
		array = QEGJGCQKBJB.Split(new string[]
		{
			" "
		}, StringSplitOptions.None);
		string[] array3 = array[0].Split(new string[]
		{
			"/"
		}, StringSplitOptions.None);
		if (array3.Length == 0)
		{
			qqkkgejlmlk.DCFKMOILHEC = 0;
			UnityEngine.Debug.Log("Test Message: " + array[0]);
		}
		else if (array3.Length == 1)
		{
			string value = Regex.Replace(array3[0], "[^0-9.-]", string.Empty);
			qqkkgejlmlk.DCFKMOILHEC = Convert.ToInt32(value);
			qqkkgejlmlk.QKBGGCKIOLG = 100;
		}
		else
		{
			string s = Regex.Replace(array3[0], "[^0-9.-]", string.Empty);
			int dcfkmoilhec = int.Parse(s);
			s = Regex.Replace(array3[1], "[^0-9.-]", string.Empty);
			int qkbggckiolg = int.Parse(s);
			qqkkgejlmlk.DCFKMOILHEC = dcfkmoilhec;
			qqkkgejlmlk.QKBGGCKIOLG = qkbggckiolg;
		}
		if (array.Length > 1)
		{
			qqkkgejlmlk.PLCBFLQBCQN = array[1];
		}
		return qqkkgejlmlk;
	}

	// Token: 0x06002F3A RID: 12090 RVA: 0x00144860 File Offset: 0x00142A60
	private IEnumerator EJFNOKENQIQ()
	{
		CNCJKLNHQBH.QOQONHOOLNE.KCMIHQPIQKI.SetActive(false);
		this.CBDCGKPHPJO = new DBQLOHBBJMG.FDJOEICCEOG[3];
		this.JELLELLGLLB = new DBQLOHBBJMG.FDJOEICCEOG[3];
		for (int i = 0; i < 3; i++)
		{
			this.CBDCGKPHPJO[i] = new DBQLOHBBJMG.FDJOEICCEOG();
			this.JELLELLGLLB[i] = new DBQLOHBBJMG.FDJOEICCEOG();
		}
		this.CEFOLQBGEJG = false;
		this.ILJPOONGEDE = true;
		int num;
		if (OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.ToggleMap(true);
			GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
			this.QQQBDBNCMCP = true;
			MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
			{
				Channel = "Battle",
				Messages = new PSXAPI.Response.Payload.ChatMessage[]
				{
					new PSXAPI.Response.Payload.ChatMessage
					{
						Message = "Battle Started.",
						Timestamp = DateTime.Now,
						Username = string.Empty,
						Pokemon = null
					}
				}
			});
			if (this.CHGQGQOEEQC)
			{
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Battle_Wild", false);
			}
			else
			{
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Trainer_Battle", false);
			}
			PCPMGFBNBKK.QOQONHOOLNE.enabled = true;
			num = UnityEngine.Random.Range(0, 10);
			yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.DDOGCDLEJMK());
			return 1;
		}
		yield break;
		if (num != 1)
		{
			goto IL_1F2;
		}
		yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.CQLKIKJLHDN(num, 0.8f));
		return 1;
		IL_1F2:
		yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.CQLKIKJLHDN(num, 0.6f));
		return 1;
		PCPMGFBNBKK.QOQONHOOLNE.enabled = false;
		CNCJKLNHQBH.QOQONHOOLNE.JLCHNMGOKGG();
		this.ILJPOONGEDE = false;
		int num2 = 0;
		goto IL_272;
		IL_255:
		CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI[num2].DIIHJCJOKMP = 0f;
		num2++;
		IL_272:
		if (num2 < CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI.Length)
		{
			goto IL_255;
		}
		int num3 = 0;
		goto IL_2A4;
		IL_287:
		CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI[num3].DIIHJCJOKMP = 0f;
		num3++;
		IL_2A4:
		if (num3 < CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI.Length)
		{
			goto IL_287;
		}
		CNCJKLNHQBH.QOQONHOOLNE.PGHJQNJLJKG.SetActive(false);
		CNCJKLNHQBH.QOQONHOOLNE.MOGNLCEFCOO.SetActive(true);
		int num4 = 0;
		goto IL_2F3;
		IL_2D9:
		this.IEGDFBICODC[num4].SetActive(false);
		num4++;
		IL_2F3:
		if (num4 < this.IEGDFBICODC.Length)
		{
			goto IL_2D9;
		}
		int num5 = UnityEngine.Random.Range(0, 3);
		bool flag = false;
		if (this.OOKMKQFENFK != 0)
		{
			goto IL_374;
		}
		if (num5 != 0)
		{
			goto IL_342;
		}
		this.IEGDFBICODC[0].SetActive(true);
		goto IL_374;
		IL_342:
		if (num5 != 1)
		{
			goto IL_360;
		}
		this.IEGDFBICODC[1].SetActive(true);
		goto IL_374;
		IL_360:
		this.IEGDFBICODC[11].SetActive(true);
		IL_374:
		if (this.OOKMKQFENFK != 1)
		{
			goto IL_395;
		}
		this.IEGDFBICODC[3].SetActive(true);
		IL_395:
		if (this.OOKMKQFENFK != 2)
		{
			goto IL_3BD;
		}
		this.IEGDFBICODC[2].SetActive(true);
		flag = true;
		IL_3BD:
		if (this.OOKMKQFENFK != 3)
		{
			goto IL_3DE;
		}
		this.IEGDFBICODC[4].SetActive(true);
		IL_3DE:
		if (this.OOKMKQFENFK != 4)
		{
			goto IL_3FF;
		}
		this.IEGDFBICODC[4].SetActive(true);
		IL_3FF:
		if (this.OOKMKQFENFK != 5)
		{
			goto IL_427;
		}
		this.IEGDFBICODC[7].SetActive(true);
		flag = true;
		IL_427:
		if (this.OOKMKQFENFK != 6)
		{
			goto IL_44F;
		}
		this.IEGDFBICODC[6].SetActive(true);
		flag = true;
		IL_44F:
		if (this.OOKMKQFENFK != 7)
		{
			goto IL_470;
		}
		this.IEGDFBICODC[8].SetActive(true);
		IL_470:
		if (this.OOKMKQFENFK != 8)
		{
			goto IL_491;
		}
		this.IEGDFBICODC[5].SetActive(true);
		IL_491:
		if (this.OOKMKQFENFK != 9)
		{
			goto IL_4B4;
		}
		this.IEGDFBICODC[10].SetActive(true);
		IL_4B4:
		if (this.OOKMKQFENFK != 10)
		{
			goto IL_4D7;
		}
		this.IEGDFBICODC[9].SetActive(true);
		IL_4D7:
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.FHMNLGJLCNH;
		RenderSettings.skybox = this.KOQMQKJJFBL[0];
		this.GOICFIMCOLK[0].color = Color.white;
		this.GOICFIMCOLK[1].color = Color.white;
		if (!flag)
		{
			goto IL_563;
		}
		RenderSettings.fogColor = this.GKIJGKFELNO[0];
		RenderSettings.fogMode = FogMode.Exponential;
		RenderSettings.fogDensity = 0.11f;
		goto IL_6C7;
		IL_563:
		RenderSettings.fogColor = this.GKIJGKFELNO[1];
		RenderSettings.fogMode = FogMode.Linear;
		RenderSettings.fogStartDistance = 30f;
		RenderSettings.fogEndDistance = 60f;
		if (this.IEGDFBICODC[4].activeSelf)
		{
			goto IL_6C7;
		}
		if (MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB != GameDayTime.Night)
		{
			goto IL_63F;
		}
		RenderSettings.skybox = this.KOQMQKJJFBL[1];
		RenderSettings.fogColor = this.GKIJGKFELNO[2];
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.JEKMPDOHJJH;
		this.GOICFIMCOLK[0].color = this.KCPOONBOQPN;
		this.GOICFIMCOLK[1].color = this.KCPOONBOQPN;
		goto IL_6C7;
		IL_63F:
		if (MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB != GameDayTime.Evening)
		{
			goto IL_6C7;
		}
		RenderSettings.skybox = this.KOQMQKJJFBL[2];
		RenderSettings.fogColor = this.GKIJGKFELNO[3];
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.FCQQFBCDGNL;
		this.GOICFIMCOLK[0].color = this.KCPOONBOQPN;
		this.GOICFIMCOLK[1].color = this.KCPOONBOQPN;
		IL_6C7:
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.OOJMKCLOQPD = true;
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.PKKIIFDNHQE();
		OHHOEHPICQF.QOQONHOOLNE.DLDBJNJJOFI(OHHOEHPICQF.IGIEDJJEGDJ.None);
		MCNLIHMMLCF.QOQONHOOLNE.FHGFKPNMNEF.SetActive(true);
		OGJJKKQPNMK component = UnityEngine.Object.Instantiate<GameObject>(this.QBEOCQCIIQM, new Vector3(0f, 0f, 0f), Quaternion.identity, this.NEQDHPDMBJK).GetComponent<OGJJKKQPNMK>();
		GGQKBGDGNJN.QOQONHOOLNE.ToggleMap(true);
		GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
		if (!(OGJJKKQPNMK.QOQONHOOLNE != component))
		{
			goto IL_772;
		}
		component.MDQEGMNKQJP();
		IL_772:
		component.gameObject.SetActive(false);
		component.HJKOHEHLJGL = this;
		component.LIEENFGKGML = this.LIEENFGKGML;
		component.LFOFQPMJFHF = true;
		this.QQQBDBNCMCP = false;
		if (!this.CHGQGQOEEQC)
		{
			goto IL_7E1;
		}
		DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Battle_Wild", false);
		goto IL_7F1;
		IL_7E1:
		DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Trainer_Battle", false);
		IL_7F1:
		yield return null;
		return 1;
	}

	// Token: 0x06002F3B RID: 12091 RVA: 0x0014487C File Offset: 0x00142A7C
	private DBQLOHBBJMG.EFQENJNJIEF CNHIHOPLMOI(string PIDLOFMIEFQ)
	{
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			return new DBQLOHBBJMG.EFQENJNJIEF
			{
				FPQBICGEHMJ = string.Empty,
				QEPKKJKQMPP = 0,
				NNHFLHEQMOI = string.Empty,
				MLKGPDPKKCE = 0
			};
		}
		DBQLOHBBJMG.EFQENJNJIEF efqenjnjief = new DBQLOHBBJMG.EFQENJNJIEF();
		efqenjnjief.QEPKKJKQMPP = -1;
		if (PIDLOFMIEFQ.Substring(2, 0) == "Icon_Pokemon_Empty")
		{
			efqenjnjief.QEPKKJKQMPP = 1;
		}
		else if (PIDLOFMIEFQ.Substring(4, 1) == ".")
		{
			efqenjnjief.QEPKKJKQMPP = 0;
		}
		else if (PIDLOFMIEFQ.Substring(8, 0) == "healbell")
		{
			efqenjnjief.QEPKKJKQMPP = 5;
		}
		if (efqenjnjief.QEPKKJKQMPP == -1)
		{
			if (PIDLOFMIEFQ.Length > 3)
			{
				efqenjnjief.NNHFLHEQMOI = PIDLOFMIEFQ.Substring(0);
				efqenjnjief.FPQBICGEHMJ = "_FogAlpha" + efqenjnjief.NNHFLHEQMOI + "All stat changes were eliminated!\r\n";
			}
			return efqenjnjief;
		}
		if (PIDLOFMIEFQ.Substring(1, 7) == "It was alerted to " && this.EDKQQKOCHPK == 0)
		{
			efqenjnjief.MLKGPDPKKCE = 0;
		}
		if (PIDLOFMIEFQ.Substring(1, 6) == "Battle" && this.EDKQQKOCHPK == 2)
		{
			efqenjnjief.MLKGPDPKKCE = 1;
		}
		if (PIDLOFMIEFQ.Substring(1, 2) == "/" && this.EDKQQKOCHPK == 1)
		{
			efqenjnjief.MLKGPDPKKCE = 0;
		}
		if (PIDLOFMIEFQ.Substring(0, 7) == "Fen Badge" && this.EDKQQKOCHPK == 7)
		{
			efqenjnjief.MLKGPDPKKCE = 0;
		}
		efqenjnjief.NNHFLHEQMOI = PIDLOFMIEFQ.Substring(0);
		if (efqenjnjief.MLKGPDPKKCE == 0)
		{
			if (this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] != null && !(this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] == string.Empty))
			{
				DBQLOHBBJMG.EFQENJNJIEF efqenjnjief2 = efqenjnjief;
				string[] array = new string[8];
				array[0] = " melted the ice!\r\n";
				array[0] = this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP];
				array[2] = "Upgrading Guild";
				array[5] = PIDLOFMIEFQ.Substring(5);
				array[4] = "CombinersColorCombine";
				efqenjnjief2.FPQBICGEHMJ = string.Concat(array);
			}
			else
			{
				efqenjnjief.FPQBICGEHMJ = "CombinersArgsAlphaSrc2" + PIDLOFMIEFQ.Substring(2) + "FOG_SCATTERING_ON";
			}
		}
		else if (this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] != null && !(this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] == string.Empty))
		{
			DBQLOHBBJMG.EFQENJNJIEF efqenjnjief3 = efqenjnjief;
			string[] array2 = new string[6];
			array2[1] = "(M)";
			array2[1] = this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP];
			array2[0] = "^emote+";
			array2[5] = PIDLOFMIEFQ.Substring(7);
			array2[3] = "Flower Veil";
			efqenjnjief3.FPQBICGEHMJ = string.Concat(array2);
		}
		else
		{
			efqenjnjief.FPQBICGEHMJ = "/trade " + PIDLOFMIEFQ.Substring(0) + "null";
		}
		return efqenjnjief;
	}

	// Token: 0x06002F3C RID: 12092 RVA: 0x000156BD File Offset: 0x000138BD
	private bool INOHJHLBJOP(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.QDMQEBHOENL(IHIHHCCEDHQ) != null;
	}

	// Token: 0x06002F3D RID: 12093 RVA: 0x00144B20 File Offset: 0x00142D20
	private DBQLOHBBJMG.QPIHHQDNQGD IGECPGMQJBJ(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.QPIHHQDNQGD qpihhqdnqgd = new DBQLOHBBJMG.QPIHHQDNQGD();
		char[] array = new char[0];
		array[0] = (char)-59;
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i += 0)
		{
			string text = array3[i];
			if (!text.Contains("_RcpMaxCoC") && !this.NEGFDQJKGKC(text.Replace("[PG]", string.Empty)))
			{
				if (!text.Contains(" declined the Friend Request.") && !this.NNLLJMOCHBQ(text))
				{
					if (!text.Contains("'s substitute faded!\r\n") && !this.JNKIDLHDPFO(text))
					{
						if (text.Contains("[ATK]") || this.LDMEEDNHPMN(text))
						{
							qpihhqdnqgd.BGDGEKEKOIE = text.Replace("/", string.Empty);
							qpihhqdnqgd.KDMEFLFNIOO = this.CPJIQMLMNOH(text.Replace("bag", string.Empty));
							qpihhqdnqgd.POLLCNHCQQC = "ffb649";
						}
					}
					else
					{
						qpihhqdnqgd.BGDGEKEKOIE = text.Replace(",", string.Empty);
						qpihhqdnqgd.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace("Unburden", string.Empty));
						qpihhqdnqgd.POLLCNHCQQC = "Pokémon in ";
					}
				}
				else
				{
					qpihhqdnqgd.BGDGEKEKOIE = text.Replace(" intends to flip up a mat and block incoming attacks!\r\n", string.Empty);
					qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("destinybond", string.Empty));
					qpihhqdnqgd.POLLCNHCQQC = "minus";
				}
			}
			else
			{
				qpihhqdnqgd.KDMEFLFNIOO = this.QFLBJNELCBI(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("poison", string.Empty)));
				qpihhqdnqgd.POLLCNHCQQC = "Hidden/ProCamera2D/TransitionsFX/";
				qpihhqdnqgd.BGDGEKEKOIE = text.Replace("_Downsample", string.Empty);
			}
		}
		if (qpihhqdnqgd.BGDGEKEKOIE == string.Empty)
		{
			qpihhqdnqgd.BGDGEKEKOIE = PIDLOFMIEFQ;
			qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(PIDLOFMIEFQ);
		}
		return qpihhqdnqgd;
	}

	// Token: 0x06002F3E RID: 12094 RVA: 0x00144D08 File Offset: 0x00142F08
	public void CKMOOOGNMFM()
	{
		for (int i = 0; i < this.IFPHQQEQBKJ.Length; i += 0)
		{
			if (this.IFPHQQEQBKJ[i] != null)
			{
				this.IFPHQQEQBKJ[i].GetComponent<EPIJJNOIKEK>().PlayReverse();
				UnityEngine.Object.Destroy(this.IFPHQQEQBKJ[i], 1205f);
				this.IFPHQQEQBKJ[i] = null;
			}
		}
		for (int j = 1; j < 6; j++)
		{
			this.OQOKJNGKEOD[j] = 0;
		}
	}

	// Token: 0x06002F3F RID: 12095 RVA: 0x00144D7C File Offset: 0x00142F7C
	public IEnumerator GLJOODPHBCN(Battle CFHEIICNLFD)
	{
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) || CFHEIICNLFD.BattleID == OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH || OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH <= 0 || !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.CHGQGQOEEQC = CFHEIICNLFD.CanCatch;
			if (!this.CEFOLQBGEJG && CFHEIICNLFD.Request1 == null && CFHEIICNLFD.Request2 == null)
			{
				if (this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
				{
					yield break;
				}
			}
			if (!this.CEFOLQBGEJG)
			{
				this.ECJEIQPGMPO = null;
				this.LGOJEHFKLCL = null;
				this.OOKMKQFENFK = CFHEIICNLFD.BackgroundID;
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
				this.BFPKBMKGDEJ = false;
				this.CLKPCHGNCPQ = new string[6];
				this.GMQKGNOMIGD = new string[6];
				this.EDKQQKOCHPK = 1;
				if (CFHEIICNLFD.Mapping1 != null)
				{
					for (int i = 0; i < CFHEIICNLFD.Mapping1.Length; i++)
					{
						if (CFHEIICNLFD.Mapping1[i].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 1;
						}
					}
				}
				if (CFHEIICNLFD.Mapping2 != null)
				{
					for (int j = 0; j < CFHEIICNLFD.Mapping2.Length; j++)
					{
						if (CFHEIICNLFD.Mapping2[j].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 2;
						}
					}
				}
				this.BFPKBMKGDEJ = false;
			}
			if (CFHEIICNLFD.Mapping1 != null)
			{
				int num = 0;
				while (num < CFHEIICNLFD.Mapping1.Length && num < 3)
				{
					if (this.EDKQQKOCHPK == 1)
					{
						this.CLKPCHGNCPQ[num] = CFHEIICNLFD.Mapping1[num];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.CLKPCHGNCPQ[num] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num] = CFHEIICNLFD.Mapping1[num];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.GMQKGNOMIGD[num] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num].trainer;
						}
					}
					num++;
				}
			}
			if (CFHEIICNLFD.Mapping2 != null)
			{
				int num2 = 0;
				while (num2 < CFHEIICNLFD.Mapping2.Length && num2 < 3)
				{
					if (this.EDKQQKOCHPK == 2)
					{
						this.CLKPCHGNCPQ[num2] = CFHEIICNLFD.Mapping2[num2];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.CLKPCHGNCPQ[num2] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num2].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num2] = CFHEIICNLFD.Mapping2[num2];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.GMQKGNOMIGD[num2] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num2].trainer;
						}
					}
					num2++;
				}
			}
			if (!this.QHLPMOPOBNJ)
			{
				this.QHLPMOPOBNJ = true;
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = true;
				}
				BattleRequest battleRequest = null;
				BattleRequest battleRequest2 = null;
				if (this.EDKQQKOCHPK == 1)
				{
					battleRequest = CFHEIICNLFD.Request1;
					battleRequest2 = CFHEIICNLFD.Request2;
				}
				else
				{
					battleRequest = CFHEIICNLFD.Request2;
					battleRequest2 = CFHEIICNLFD.Request1;
				}
				int num3 = 0;
				if (!this.CEFOLQBGEJG && CFHEIICNLFD.Log != null)
				{
					foreach (string text in CFHEIICNLFD.Log)
					{
						num3++;
						string[] array = text.Split(new char[]
						{
							'|'
						});
						if (array.Length > 1)
						{
							string text2 = array[1];
							if (text2 != null && text2 == "switch" && (num3 + 1 >= CFHEIICNLFD.Log.Length || CFHEIICNLFD.Log[num3 + 1].Length <= 10 || !(CFHEIICNLFD.Log[num3 + 1].Substring(0, 10) == text.Substring(0, 10))))
							{
								string text3 = string.Empty;
								string s = string.Empty;
								DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk;
								if (array.Length >= 7)
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], array[4]);
									text3 = array[5];
									s = array[6];
								}
								else
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], string.Empty);
									text3 = array[4];
									s = array[5];
								}
								DBQLOHBBJMG.EFQENJNJIEF efqenjnjief = this.LMHQBCEBPHG(array[2]);
								int qkneijqhgcb = 0;
								int.TryParse(s, out qkneijqhgcb);
								OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
								mffgqcjkpbd.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD.ToString();
								mffgqcjkpbd.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
								mffgqcjkpbd.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
								mffgqcjkpbd.QKNEIJQHGCB = qkneijqhgcb;
								if (efqenjnjief.MLKGPDPKKCE == 0)
								{
									if (this.ECJEIQPGMPO == null)
									{
										this.ECJEIQPGMPO = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
								else
								{
									if (this.LGOJEHFKLCL == null)
									{
										this.LGOJEHFKLCL = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
							}
						}
					}
				}
				if (battleRequest != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest, CFHEIICNLFD.BattleID));
				}
				else if (battleRequest2 != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest2, CFHEIICNLFD.BattleID));
				}
				else if (CFHEIICNLFD.Log != null)
				{
					yield return base.StartCoroutine(this.HIHHCNIPPHL(CFHEIICNLFD.Log, false, battleRequest, battleRequest2));
				}
				else
				{
					if (!this.CEFOLQBGEJG)
					{
						OGJJKKQPNMK qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
						if (qoqonhoolne != null)
						{
							qoqonhoolne.POKGLNOCHJE = UnityEngine.Time.time;
							if (CFHEIICNLFD.Timer > 0)
							{
								qoqonhoolne.MHKFGIGILMB = (float)CFHEIICNLFD.Timer;
								qoqonhoolne.JJJGDPOKQPP = true;
							}
							else
							{
								qoqonhoolne.JJJGDPOKQPP = false;
								qoqonhoolne.MHKFGIGILMB = 90f;
							}
							qoqonhoolne.FCMNJOPQBKQ = CFHEIICNLFD.CanEscape;
							qoqonhoolne.LJDIQKPJIJN = CFHEIICNLFD.CanUseItem;
							qoqonhoolne.GHQOEDBJDNI = CFHEIICNLFD.CanCatch;
						}
					}
					if (this.DMIEIKIPDII)
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.POKGLNOCHJE = UnityEngine.Time.time;
						}
						this.DMIEIKIPDII = false;
					}
					if (!this.CEFOLQBGEJG)
					{
						this.CEFOLQBGEJG = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							for (int l = 0; l < OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE.Length; l++)
							{
								if (this.CBDCGKPHPJO != null)
								{
									this.CBDCGKPHPJO[l].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.KMNQBFKKNMB;
									this.CBDCGKPHPJO[l].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.CBDCGKPHPJO[l].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.EOMPMQNGIBD;
									this.CBDCGKPHPJO[l].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.HHNOCOQJOJF;
									this.CBDCGKPHPJO[l].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.QKNEIJQHGCB;
									this.CBDCGKPHPJO[l].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DBPKNCDGGEP;
									this.CBDCGKPHPJO[l].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.PLCBFLQBCQN;
									this.CBDCGKPHPJO[l].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.BKNFHNFFCHE;
									this.CBDCGKPHPJO[l].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
							for (int m = 0; m < OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI.Length; m++)
							{
								if (this.JELLELLGLLB != null)
								{
									this.JELLELLGLLB[m].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.KMNQBFKKNMB;
									this.JELLELLGLLB[m].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.JELLELLGLLB[m].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.EOMPMQNGIBD;
									this.JELLELLGLLB[m].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.HHNOCOQJOJF;
									this.JELLELLGLLB[m].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.QKNEIJQHGCB;
									this.JELLELLGLLB[m].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DBPKNCDGGEP;
									this.JELLELLGLLB[m].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.PLCBFLQBCQN;
									this.JELLELLGLLB[m].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.BKNFHNFFCHE;
									this.JELLELLGLLB[m].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
						}
					}
					this.DMIEIKIPDII = false;
					if (battleRequest == null && battleRequest2 == null && this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						}
					}
					else if (OGJJKKQPNMK.QOQONHOOLNE != null)
					{
						OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH = 0;
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						OGJJKKQPNMK.QOQONHOOLNE.PDDJMNOOPJD(false);
					}
					if (CFHEIICNLFD.Ended && !this.BFPKBMKGDEJ)
					{
						this.BFPKBMKGDEJ = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							yield return base.StartCoroutine(OGJJKKQPNMK.QOQONHOOLNE.BDOQHKILDHC());
							return 1;
						}
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.MELOIMCMIGN();
					}
					this.NDEDPKOEDIB = false;
					this.QHLPMOPOBNJ = false;
					CNCJKLNHQBH.QOQONHOOLNE.MGFDFQDMGPG = null;
					yield return null;
				}
			}
			else
			{
				yield return false;
			}
		}
		else
		{
			yield return false;
		}
		return 1;
		yield break;
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x00144D7C File Offset: 0x00142F7C
	public IEnumerator JNIFGLMDEBQ(Battle CFHEIICNLFD)
	{
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) || CFHEIICNLFD.BattleID == OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH || OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH <= 0 || !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.CHGQGQOEEQC = CFHEIICNLFD.CanCatch;
			if (!this.CEFOLQBGEJG && CFHEIICNLFD.Request1 == null && CFHEIICNLFD.Request2 == null)
			{
				if (this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
				{
					yield break;
				}
			}
			if (!this.CEFOLQBGEJG)
			{
				this.ECJEIQPGMPO = null;
				this.LGOJEHFKLCL = null;
				this.OOKMKQFENFK = CFHEIICNLFD.BackgroundID;
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
				this.BFPKBMKGDEJ = false;
				this.CLKPCHGNCPQ = new string[6];
				this.GMQKGNOMIGD = new string[6];
				this.EDKQQKOCHPK = 1;
				if (CFHEIICNLFD.Mapping1 != null)
				{
					for (int i = 0; i < CFHEIICNLFD.Mapping1.Length; i++)
					{
						if (CFHEIICNLFD.Mapping1[i].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 1;
						}
					}
				}
				if (CFHEIICNLFD.Mapping2 != null)
				{
					for (int j = 0; j < CFHEIICNLFD.Mapping2.Length; j++)
					{
						if (CFHEIICNLFD.Mapping2[j].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 2;
						}
					}
				}
				this.BFPKBMKGDEJ = false;
			}
			if (CFHEIICNLFD.Mapping1 != null)
			{
				int num4 = 0;
				while (num4 < CFHEIICNLFD.Mapping1.Length && num4 < 3)
				{
					if (this.EDKQQKOCHPK == 1)
					{
						this.CLKPCHGNCPQ[num4] = CFHEIICNLFD.Mapping1[num4];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.CLKPCHGNCPQ[num4] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num4].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num4] = CFHEIICNLFD.Mapping1[num4];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.GMQKGNOMIGD[num4] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num4].trainer;
						}
					}
					num4++;
				}
			}
			if (CFHEIICNLFD.Mapping2 != null)
			{
				int num5 = 0;
				while (num5 < CFHEIICNLFD.Mapping2.Length && num5 < 3)
				{
					if (this.EDKQQKOCHPK == 2)
					{
						this.CLKPCHGNCPQ[num5] = CFHEIICNLFD.Mapping2[num5];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.CLKPCHGNCPQ[num5] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num5].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num5] = CFHEIICNLFD.Mapping2[num5];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.GMQKGNOMIGD[num5] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num5].trainer;
						}
					}
					num5++;
				}
			}
			if (!this.QHLPMOPOBNJ)
			{
				this.QHLPMOPOBNJ = true;
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = true;
				}
				battleRequest = null;
				battleRequest2 = null;
				if (this.EDKQQKOCHPK == 1)
				{
					battleRequest = CFHEIICNLFD.Request1;
					battleRequest2 = CFHEIICNLFD.Request2;
				}
				else
				{
					battleRequest = CFHEIICNLFD.Request2;
					battleRequest2 = CFHEIICNLFD.Request1;
				}
				num3 = 0;
				if (!this.CEFOLQBGEJG && CFHEIICNLFD.Log != null)
				{
					foreach (string text in CFHEIICNLFD.Log)
					{
						num3++;
						string[] array = text.Split(new char[]
						{
							'|'
						});
						if (array.Length > 1)
						{
							string text2 = array[1];
							if (text2 != null && text2 == "switch" && (num3 + 1 >= CFHEIICNLFD.Log.Length || CFHEIICNLFD.Log[num3 + 1].Length <= 10 || !(CFHEIICNLFD.Log[num3 + 1].Substring(0, 10) == text.Substring(0, 10))))
							{
								string text3 = string.Empty;
								string s = string.Empty;
								DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk;
								if (array.Length >= 7)
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], array[4]);
									text3 = array[5];
									s = array[6];
								}
								else
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], string.Empty);
									text3 = array[4];
									s = array[5];
								}
								DBQLOHBBJMG.EFQENJNJIEF efqenjnjief = this.LMHQBCEBPHG(array[2]);
								int qkneijqhgcb = 0;
								int.TryParse(s, out qkneijqhgcb);
								OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
								mffgqcjkpbd.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD.ToString();
								mffgqcjkpbd.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
								mffgqcjkpbd.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
								mffgqcjkpbd.QKNEIJQHGCB = qkneijqhgcb;
								if (efqenjnjief.MLKGPDPKKCE == 0)
								{
									if (this.ECJEIQPGMPO == null)
									{
										this.ECJEIQPGMPO = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
								else
								{
									if (this.LGOJEHFKLCL == null)
									{
										this.LGOJEHFKLCL = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
							}
						}
					}
				}
				if (battleRequest != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest, CFHEIICNLFD.BattleID));
				}
				else if (battleRequest2 != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest2, CFHEIICNLFD.BattleID));
				}
				else if (CFHEIICNLFD.Log != null)
				{
					yield return base.StartCoroutine(this.HIHHCNIPPHL(CFHEIICNLFD.Log, false, battleRequest, battleRequest2));
				}
				else
				{
					if (!this.CEFOLQBGEJG)
					{
						OGJJKKQPNMK qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
						if (qoqonhoolne != null)
						{
							qoqonhoolne.POKGLNOCHJE = UnityEngine.Time.time;
							if (CFHEIICNLFD.Timer > 0)
							{
								qoqonhoolne.MHKFGIGILMB = (float)CFHEIICNLFD.Timer;
								qoqonhoolne.JJJGDPOKQPP = true;
							}
							else
							{
								qoqonhoolne.JJJGDPOKQPP = false;
								qoqonhoolne.MHKFGIGILMB = 90f;
							}
							qoqonhoolne.FCMNJOPQBKQ = CFHEIICNLFD.CanEscape;
							qoqonhoolne.LJDIQKPJIJN = CFHEIICNLFD.CanUseItem;
							qoqonhoolne.GHQOEDBJDNI = CFHEIICNLFD.CanCatch;
						}
					}
					if (this.DMIEIKIPDII)
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.POKGLNOCHJE = UnityEngine.Time.time;
						}
						this.DMIEIKIPDII = false;
					}
					if (!this.CEFOLQBGEJG)
					{
						this.CEFOLQBGEJG = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							for (int l = 0; l < OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE.Length; l++)
							{
								if (this.CBDCGKPHPJO != null)
								{
									this.CBDCGKPHPJO[l].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.KMNQBFKKNMB;
									this.CBDCGKPHPJO[l].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.CBDCGKPHPJO[l].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.EOMPMQNGIBD;
									this.CBDCGKPHPJO[l].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.HHNOCOQJOJF;
									this.CBDCGKPHPJO[l].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.QKNEIJQHGCB;
									this.CBDCGKPHPJO[l].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DBPKNCDGGEP;
									this.CBDCGKPHPJO[l].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.PLCBFLQBCQN;
									this.CBDCGKPHPJO[l].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.BKNFHNFFCHE;
									this.CBDCGKPHPJO[l].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
							for (int m = 0; m < OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI.Length; m++)
							{
								if (this.JELLELLGLLB != null)
								{
									this.JELLELLGLLB[m].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.KMNQBFKKNMB;
									this.JELLELLGLLB[m].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.JELLELLGLLB[m].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.EOMPMQNGIBD;
									this.JELLELLGLLB[m].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.HHNOCOQJOJF;
									this.JELLELLGLLB[m].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.QKNEIJQHGCB;
									this.JELLELLGLLB[m].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DBPKNCDGGEP;
									this.JELLELLGLLB[m].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.PLCBFLQBCQN;
									this.JELLELLGLLB[m].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.BKNFHNFFCHE;
									this.JELLELLGLLB[m].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
						}
					}
					this.DMIEIKIPDII = false;
					if (battleRequest == null && battleRequest2 == null && this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						}
					}
					else if (OGJJKKQPNMK.QOQONHOOLNE != null)
					{
						OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH = 0;
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						OGJJKKQPNMK.QOQONHOOLNE.PDDJMNOOPJD(false);
					}
					if (CFHEIICNLFD.Ended && !this.BFPKBMKGDEJ)
					{
						this.BFPKBMKGDEJ = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							yield return base.StartCoroutine(OGJJKKQPNMK.QOQONHOOLNE.BDOQHKILDHC());
							return 1;
						}
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.MELOIMCMIGN();
					}
					this.NDEDPKOEDIB = false;
					this.QHLPMOPOBNJ = false;
					CNCJKLNHQBH.QOQONHOOLNE.MGFDFQDMGPG = null;
					yield return null;
				}
			}
			else
			{
				yield return false;
			}
		}
		else
		{
			yield return false;
		}
		return 1;
		yield break;
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x000156CA File Offset: 0x000138CA
	private bool KPCKMMCQEEE(string IHIHHCCEDHQ)
	{
		if (!string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace(" ability: ", string.Empty);
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace("ability: ", string.Empty);
		}
		return KGQECFKLKOP.DPDPPDNIFQN(IHIHHCCEDHQ) != null;
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x00015703 File Offset: 0x00013903
	public string QFLBJNELCBI(string PIDLOFMIEFQ)
	{
		return Regex.Replace(PIDLOFMIEFQ, "Plant", string.Empty, RegexOptions.IgnoreCase).ToLowerInvariant();
	}

	// Token: 0x06002F43 RID: 12099 RVA: 0x0001571B File Offset: 0x0001391B
	public void ELEMIGPDGLD(PSXAPI.Response.BattleSide BJGCBDNBQCJ)
	{
		if (!string.IsNullOrEmpty(BJGCBDNBQCJ.Data) && BJGCBDNBQCJ.Data.Contains("_FogData"))
		{
			base.StartCoroutine(this.NEJKEQBQMOC("[00FF00]+", true));
			OGJJKKQPNMK.QOQONHOOLNE.JENCFKOGOKF();
		}
	}

	// Token: 0x06002F44 RID: 12100 RVA: 0x00144DA0 File Offset: 0x00142FA0
	public void EPQJQILCNOE(BattleBroadcast BJGCBDNBQCJ)
	{
		if (OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			return;
		}
		if (OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length < 2)
		{
			return;
		}
		if (BJGCBDNBQCJ.Message != null)
		{
			EODGHGDGKLC[] array = new EODGHGDGKLC[6];
			string[] array2 = BJGCBDNBQCJ.Message.Split(new string[]
			{
				"|"
			}, StringSplitOptions.None);
			string str = array2[1];
			int num = 0;
			Transform ilbcccbjncl = null;
			int.TryParse(array2[2], out num);
			int num2 = 0;
			if (num == 0)
			{
				ilbcccbjncl = null;
			}
			else if (num > -1)
			{
				if (num - 1 >= 0 && num - 1 < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length)
				{
					ilbcccbjncl = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[num - 1].transform;
					num2 = num - 1 + 3;
				}
			}
			else if (-num - 1 >= 0 && num - 1 < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length)
			{
				ilbcccbjncl = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[-num - 1].transform;
				num2 = -num - 1;
			}
			int num3 = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length;
			string text = array2[0];
			if (text != null)
			{
				if (!(text == "1"))
				{
					if (!(text == "2"))
					{
						if (!(text == "3"))
						{
							if (!(text == "4"))
							{
								if (text == "5")
								{
									MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
									{
										Channel = "Battle",
										Messages = new PSXAPI.Response.Payload.ChatMessage[]
										{
											new PSXAPI.Response.Payload.ChatMessage
											{
												Message = BJGCBDNBQCJ.Username + " has chosen to run.",
												Timestamp = DateTime.Now,
												Username = string.Empty,
												Pokemon = null
											}
										}
									});
								}
							}
							else
							{
								MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
								{
									Channel = "Battle",
									Messages = new PSXAPI.Response.Payload.ChatMessage[]
									{
										new PSXAPI.Response.Payload.ChatMessage
										{
											Message = BJGCBDNBQCJ.Username + " has chosen to shift.",
											Timestamp = DateTime.Now,
											Username = string.Empty,
											Pokemon = null
										}
									}
								});
							}
						}
						else
						{
							MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
							{
								Channel = "Battle",
								Messages = new PSXAPI.Response.Payload.ChatMessage[]
								{
									new PSXAPI.Response.Payload.ChatMessage
									{
										Message = BJGCBDNBQCJ.Username + " has chosen to use an item.",
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									}
								}
							});
						}
					}
					else
					{
						MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
						{
							Channel = "Battle",
							Messages = new PSXAPI.Response.Payload.ChatMessage[]
							{
								new PSXAPI.Response.Payload.ChatMessage
								{
									Message = BJGCBDNBQCJ.Username + " has chosen to use a Pokeball.",
									Timestamp = DateTime.Now,
									Username = string.Empty,
									Pokemon = null
								}
							}
						});
						EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "[BATTLE]" + str;
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[num2] * 0.5f, 0f);
						eodghgdgklc.enabled = true;
						this.OQOKJNGKEOD[num2]++;
					}
				}
				else
				{
					int num4 = Convert.ToInt32(array2[4]);
					string a = array2[5];
					if (!(a == "normal") && !(a == string.Empty) && !(a == "any") && !(a == "adjacentAllyOrSelf") && !(a == "adjacentAlly") && !(a == "adjacentFoe"))
					{
						if (a == "self")
						{
							ilbcccbjncl = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[Convert.ToInt32(array2[4])].transform;
							EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
							eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
							eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
							eodghgdgklc.LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[num2] * 0.5f, 0f);
							eodghgdgklc.enabled = true;
							this.OQOKJNGKEOD[num2]++;
						}
						else if (a == "allAdjacentFoes")
						{
							if (num4 == 0)
							{
								if (num3 == 2)
								{
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "0");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[3] * 0.5f, 0f);
									array[0].enabled = true;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "1");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[4] * 0.5f, 0f);
									array[1].enabled = true;
									this.OQOKJNGKEOD[3]++;
									this.OQOKJNGKEOD[4]++;
								}
								else if (num3 == 3)
								{
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "0");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[4] * 0.5f, 0f);
									array[0].enabled = true;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "1");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[2].transform;
									array[1].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[5] * 0.5f, 0f);
									array[1].enabled = true;
									this.OQOKJNGKEOD[4]++;
									this.OQOKJNGKEOD[5]++;
								}
							}
							else if (num4 == 1)
							{
								for (int i = 0; i < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; i++)
								{
									array[i] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + i.ToString());
									array[i].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[i].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[i].transform;
									array[i].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[i + 3] * 0.5f, 0f);
									array[i].enabled = true;
									this.OQOKJNGKEOD[i + 3]++;
								}
							}
							else if (num4 == 2)
							{
								array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "1");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
								array[0].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[3] * 0.5f, 0f);
								array[0].enabled = true;
								array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "2");
								array[1].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[4] * 0.5f, 0f);
								array[1].enabled = true;
								this.OQOKJNGKEOD[3]++;
								this.OQOKJNGKEOD[4]++;
							}
						}
						else if (a == "allAdjacent")
						{
							if (num4 == 0)
							{
								if (num3 == 2)
								{
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "0");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[3] * 0.5f, 0f);
									array[0].enabled = true;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "1");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[4] * 0.5f, 0f);
									array[1].enabled = true;
									array[2] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "-2");
									array[2].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[2].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[1].transform;
									array[2].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[1] * 0.5f, 0f);
									array[2].enabled = true;
									this.OQOKJNGKEOD[3]++;
									this.OQOKJNGKEOD[4]++;
									this.OQOKJNGKEOD[1]++;
								}
								else if (num3 == 3)
								{
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "0");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[4] * 0.5f, 0f);
									array[0].enabled = true;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "1");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[2].transform;
									array[1].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[5] * 0.5f, 0f);
									array[1].enabled = true;
									array[2] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "-2");
									array[2].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[2].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[1].transform;
									array[2].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[1] * 0.5f, 0f);
									array[2].enabled = true;
									this.OQOKJNGKEOD[4]++;
									this.OQOKJNGKEOD[5]++;
									this.OQOKJNGKEOD[1]++;
								}
							}
							else if (num4 == 1)
							{
								for (int j = 0; j < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; j++)
								{
									array[j] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + j.ToString());
									array[j].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[j].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[j].transform;
									array[j].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[j] * 0.5f, 0f);
									array[j].enabled = true;
									this.OQOKJNGKEOD[j]++;
								}
								for (int k = 0; k < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; k++)
								{
									array[k + 3] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (k + 3).ToString());
									array[k + 3].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[k + 3].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[k].transform;
									array[k + 3].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[k + 3] * 0.5f, 0f);
									array[k + 3].enabled = true;
									this.OQOKJNGKEOD[k + 3]++;
								}
							}
							else if (num4 == 2)
							{
								array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "1");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
								array[0].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[3] * 0.5f, 0f);
								array[0].enabled = true;
								array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "2");
								array[1].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[4] * 0.5f, 0f);
								array[1].enabled = true;
								array[2] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "-1");
								array[2].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
								array[2].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[0].transform;
								array[2].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[0] * 0.5f, 0f);
								array[2].enabled = true;
								this.OQOKJNGKEOD[3]++;
								this.OQOKJNGKEOD[4]++;
								this.OQOKJNGKEOD[0]++;
							}
						}
						else if (a == "foeSide")
						{
							for (int l = 0; l < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; l++)
							{
								array[l] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + l.ToString());
								array[l].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
								array[l].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[l].transform;
								array[l].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[l + 3] * 0.5f, 0f);
								array[l].enabled = true;
								this.OQOKJNGKEOD[l + 3]++;
							}
						}
						else if (!(a == "allySide") && !(a == "allyTeam"))
						{
							if (a == "all")
							{
								for (int m = 0; m < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; m++)
								{
									array[m] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + m.ToString());
									array[m].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[m].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[m].transform;
									array[m].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[m] * 0.5f, 0f);
									array[m].enabled = true;
									this.OQOKJNGKEOD[m]++;
								}
								for (int n = 0; n < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; n++)
								{
									array[n + 3] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (n + 3).ToString());
									array[n + 3].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
									array[n + 3].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[n].transform;
									array[n + 3].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[n + 3] * 0.5f, 0f);
									array[n + 3].enabled = true;
									this.OQOKJNGKEOD[n + 3]++;
								}
							}
						}
						else
						{
							for (int num5 = 0; num5 < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; num5++)
							{
								array[num5] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + num5.ToString());
								array[num5].DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
								array[num5].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[num5].transform;
								array[num5].LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[num5] * 0.5f, 0f);
								array[num5].enabled = true;
								this.OQOKJNGKEOD[num5]++;
							}
						}
					}
					else
					{
						EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "[ATK]" + str;
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(0f, (float)this.OQOKJNGKEOD[num2] * 0.5f, 0f);
						eodghgdgklc.enabled = true;
						this.OQOKJNGKEOD[num2]++;
					}
					MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
					{
						Channel = "Battle",
						Messages = new PSXAPI.Response.Payload.ChatMessage[]
						{
							new PSXAPI.Response.Payload.ChatMessage
							{
								Message = BJGCBDNBQCJ.Username + " has chosen an Attack.",
								Timestamp = DateTime.Now,
								Username = string.Empty,
								Pokemon = null
							}
						}
					});
				}
			}
		}
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x00015759 File Offset: 0x00013959
	private bool NNNLEQNNHPL(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.QDMQEBHOENL(IHIHHCCEDHQ) == null || true;
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x00146280 File Offset: 0x00144480
	private DBQLOHBBJMG.EFQENJNJIEF LMHQBCEBPHG(string PIDLOFMIEFQ)
	{
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			return new DBQLOHBBJMG.EFQENJNJIEF
			{
				FPQBICGEHMJ = string.Empty,
				QEPKKJKQMPP = 0,
				NNHFLHEQMOI = string.Empty,
				MLKGPDPKKCE = 0
			};
		}
		DBQLOHBBJMG.EFQENJNJIEF efqenjnjief = new DBQLOHBBJMG.EFQENJNJIEF();
		efqenjnjief.QEPKKJKQMPP = -1;
		if (PIDLOFMIEFQ.Substring(2, 1) == "a")
		{
			efqenjnjief.QEPKKJKQMPP = 0;
		}
		else if (PIDLOFMIEFQ.Substring(2, 1) == "b")
		{
			efqenjnjief.QEPKKJKQMPP = 1;
		}
		else if (PIDLOFMIEFQ.Substring(2, 1) == "c")
		{
			efqenjnjief.QEPKKJKQMPP = 2;
		}
		if (efqenjnjief.QEPKKJKQMPP == -1)
		{
			if (PIDLOFMIEFQ.Length > 4)
			{
				efqenjnjief.NNHFLHEQMOI = PIDLOFMIEFQ.Substring(4);
				efqenjnjief.FPQBICGEHMJ = "[ff6600]" + efqenjnjief.NNHFLHEQMOI + "[-]";
			}
			return efqenjnjief;
		}
		if (PIDLOFMIEFQ.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 1)
		{
			efqenjnjief.MLKGPDPKKCE = 1;
		}
		if (PIDLOFMIEFQ.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 2)
		{
			efqenjnjief.MLKGPDPKKCE = 0;
		}
		if (PIDLOFMIEFQ.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 1)
		{
			efqenjnjief.MLKGPDPKKCE = 0;
		}
		if (PIDLOFMIEFQ.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 2)
		{
			efqenjnjief.MLKGPDPKKCE = 1;
		}
		efqenjnjief.NNHFLHEQMOI = PIDLOFMIEFQ.Substring(5);
		if (efqenjnjief.MLKGPDPKKCE == 0)
		{
			if (this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] != null && !(this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] == string.Empty))
			{
				efqenjnjief.FPQBICGEHMJ = string.Concat(new string[]
				{
					"[ff6666]",
					this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP],
					"[-]'s [ff6600]",
					PIDLOFMIEFQ.Substring(5),
					"[-]"
				});
			}
			else
			{
				efqenjnjief.FPQBICGEHMJ = "[ff6600]" + PIDLOFMIEFQ.Substring(5) + "[-]";
			}
		}
		else if (this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] != null && !(this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] == string.Empty))
		{
			efqenjnjief.FPQBICGEHMJ = string.Concat(new string[]
			{
				"[ff6666]",
				this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP],
				"[-]'s [ff6600]",
				PIDLOFMIEFQ.Substring(5),
				"[-]"
			});
		}
		else
		{
			efqenjnjief.FPQBICGEHMJ = "[ff6600]" + PIDLOFMIEFQ.Substring(5) + "[-]";
		}
		return efqenjnjief;
	}

	// Token: 0x06002F47 RID: 12103 RVA: 0x00146524 File Offset: 0x00144724
	public void DLHOOIEBFHE(BattleBroadcast BJGCBDNBQCJ)
	{
		if (OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			return;
		}
		if (OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length < 4)
		{
			return;
		}
		if (BJGCBDNBQCJ.Message != null)
		{
			EODGHGDGKLC[] array = new EODGHGDGKLC[3];
			string message = BJGCBDNBQCJ.Message;
			string[] array2 = new string[0];
			array2[0] = " protected itself!\r\n";
			string[] array3 = message.Split(array2, StringSplitOptions.RemoveEmptyEntries);
			string str = array3[0];
			int num = 1;
			Transform ilbcccbjncl = null;
			int.TryParse(array3[0], out num);
			int num2 = 0;
			if (num == 0)
			{
				ilbcccbjncl = null;
			}
			else if (num > -1)
			{
				if (num - 0 >= 0 && num - 1 < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length)
				{
					ilbcccbjncl = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[num - 1].transform;
					num2 = num - 0 + 2;
				}
			}
			else if (-num - 0 >= 1 && num - 0 < OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length)
			{
				ilbcccbjncl = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[-num - 1].transform;
				num2 = -num - 1;
			}
			int num3 = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG.Length;
			string text = array3[1];
			if (text != null)
			{
				if (!(text == "spectatorleave"))
				{
					if (!(text == "'"))
					{
						if (!(text == "imprison"))
						{
							if (!(text == "stockpile1"))
							{
								if (text == "'.")
								{
									MBGHQMKEFKO.QOQONHOOLNE.NDJFBGECGBG(new PSXAPI.Response.ChatMessage
									{
										Channel = "[PG]",
										Messages = new PSXAPI.Response.Payload.ChatMessage[]
										{
											new PSXAPI.Response.Payload.ChatMessage
											{
												Message = BJGCBDNBQCJ.Username + "pickup",
												Timestamp = DateTime.Now,
												Username = string.Empty,
												Pokemon = null
											}
										}
									});
								}
							}
							else
							{
								MBGHQMKEFKO.KGOPJQOMMNC().NDJFBGECGBG(new PSXAPI.Response.ChatMessage
								{
									Channel = "OnPress",
									Messages = new PSXAPI.Response.Payload.ChatMessage[]
									{
										new PSXAPI.Response.Payload.ChatMessage
										{
											Message = BJGCBDNBQCJ.Username + "[silent]",
											Timestamp = DateTime.Now,
											Username = string.Empty,
											Pokemon = null
										}
									}
								});
							}
						}
						else
						{
							MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.KGOPJQOMMNC();
							PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
							chatMessage.Channel = "!\r\n";
							PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
							PSXAPI.Response.Payload.ChatMessage[] array4 = new PSXAPI.Response.Payload.ChatMessage[1];
							array4[1] = new PSXAPI.Response.Payload.ChatMessage
							{
								Message = BJGCBDNBQCJ.Username + "(I)",
								Timestamp = DateTime.Now,
								Username = string.Empty,
								Pokemon = null
							};
							chatMessage2.Messages = array4;
							mbghqmkefko.PLMHOIOFOBK(chatMessage);
						}
					}
					else
					{
						MBGHQMKEFKO.KGOPJQOMMNC().NDJFBGECGBG(new PSXAPI.Response.ChatMessage
						{
							Channel = ":",
							Messages = new PSXAPI.Response.Payload.ChatMessage[]
							{
								new PSXAPI.Response.Payload.ChatMessage
								{
									Message = BJGCBDNBQCJ.Username + "\n[PG]",
									Timestamp = DateTime.Now,
									Username = string.Empty,
									Pokemon = null
								}
							}
						});
						EODGHGDGKLC eodghgdgklc = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("aromatherapy" + str);
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(775f, (float)this.OQOKJNGKEOD[num2] * 1085f, 452f);
						eodghgdgklc.enabled = false;
						this.OQOKJNGKEOD[num2]++;
					}
				}
				else
				{
					int num4 = Convert.ToInt32(array3[8]);
					string a = array3[7];
					if (!(a == "[itm=") && !(a == string.Empty) && !(a == "50/50") && !(a == "When the flame touched the powder on the Pokémon, it exploded!\r\n") && !(a == "Enabled") && !(a == "#,##0"))
					{
						if (a == "allyTeam")
						{
							ilbcccbjncl = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[Convert.ToInt32(array3[6])].transform;
							EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
							eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "[00]" + str;
							eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
							eodghgdgklc.LCMMCNFNHMF += new Vector3(1955f, (float)this.OQOKJNGKEOD[num2] * 628f, 1604f);
							eodghgdgklc.enabled = false;
							this.OQOKJNGKEOD[num2]++;
						}
						else if (a == "Right")
						{
							if (num4 == 0)
							{
								if (num3 == 3)
								{
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "\r\nLv ");
									array[1].DGENOHPIECM.LKPOBCBOFIC("Update" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(938f, (float)this.OQOKJNGKEOD[0] * 89f, 1307f);
									array[0].enabled = false;
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "grudge");
									array[0].DGENOHPIECM.LKPOBCBOFIC("soundproof" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(222f, (float)this.OQOKJNGKEOD[3] * 1353f, 727f);
									array[1].enabled = true;
									this.OQOKJNGKEOD[5] += 0;
									this.OQOKJNGKEOD[4] += 0;
								}
								else if (num3 == 0)
								{
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "Battle");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "par" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(1554f, (float)this.OQOKJNGKEOD[2] * 1563f, 1453f);
									array[0].enabled = true;
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "FactoryTempTexture");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "9" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[2].transform;
									array[0].LCMMCNFNHMF += new Vector3(592f, (float)this.OQOKJNGKEOD[0] * 802f, 465f);
									array[0].enabled = false;
									this.OQOKJNGKEOD[4]++;
									this.OQOKJNGKEOD[0] += 0;
								}
							}
							else if (num4 == 0)
							{
								for (int i = 1; i < OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG.Length; i += 0)
								{
									array[i] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + i.ToString());
									array[i].DGENOHPIECM.PIDLOFMIEFQ = "HidePanel" + str;
									array[i].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[i].transform;
									array[i].LCMMCNFNHMF += new Vector3(1868f, (float)this.OQOKJNGKEOD[i + 5] * 1460f, 1355f);
									array[i].enabled = false;
									this.OQOKJNGKEOD[i + 0]++;
								}
							}
							else if (num4 == 0)
							{
								array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "bind");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "BuffIcon_ElectricIncrease" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
								array[1].LCMMCNFNHMF += new Vector3(736f, (float)this.OQOKJNGKEOD[8] * 1059f, 416f);
								array[0].enabled = true;
								array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + ".");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = " is damaged by the recoil!\r\n" + str;
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(1342f, (float)this.OQOKJNGKEOD[0] * 1451f, 1532f);
								array[0].enabled = true;
								this.OQOKJNGKEOD[4] += 0;
								this.OQOKJNGKEOD[8]++;
							}
						}
						else if (a == "n")
						{
							if (num4 == 0)
							{
								if (num3 == 6)
								{
									array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + " lost its focus and couldn't move!\r\n");
									array[1].DGENOHPIECM.LKPOBCBOFIC("TweenLetters encountered an unhandled case trying to modify a vertex " + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(558f, (float)this.OQOKJNGKEOD[8] * 1475f, 393f);
									array[1].enabled = true;
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "fairy");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "_Texture0" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(1332f, (float)this.OQOKJNGKEOD[3] * 857f, 730f);
									array[1].enabled = true;
									array[8] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "Unnerves opposing Pokémon and makes them unable to eat Berries.");
									array[6].DGENOHPIECM.LKPOBCBOFIC("Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!" + str);
									array[3].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[0].transform;
									array[8].LCMMCNFNHMF += new Vector3(961f, (float)this.OQOKJNGKEOD[1] * 1234f, 766f);
									array[8].enabled = false;
									this.OQOKJNGKEOD[5]++;
									this.OQOKJNGKEOD[5]++;
									this.OQOKJNGKEOD[1]++;
								}
								else if (num3 == 1)
								{
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "bide");
									array[1].DGENOHPIECM.LKPOBCBOFIC("_Fade" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(1245f, (float)this.OQOKJNGKEOD[0] * 549f, 1535f);
									array[0].enabled = false;
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "(W)");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "#,##0" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[2].transform;
									array[1].LCMMCNFNHMF += new Vector3(1240f, (float)this.OQOKJNGKEOD[2] * 641f, 1006f);
									array[0].enabled = true;
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + " shared its power with ");
									array[3].DGENOHPIECM.LKPOBCBOFIC("\"" + str);
									array[3].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[0].transform;
									array[4].LCMMCNFNHMF += new Vector3(787f, (float)this.OQOKJNGKEOD[1] * 1402f, 1945f);
									array[6].enabled = true;
									this.OQOKJNGKEOD[8]++;
									this.OQOKJNGKEOD[2] += 0;
									this.OQOKJNGKEOD[1]++;
								}
							}
							else if (num4 == 0)
							{
								for (int j = 0; j < OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length; j += 0)
								{
									array[j] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + j.ToString());
									array[j].DGENOHPIECM.LKPOBCBOFIC("inactiveoff" + str);
									array[j].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[j].transform;
									array[j].LCMMCNFNHMF += new Vector3(1806f, (float)this.OQOKJNGKEOD[j] * 1891f, 102f);
									array[j].enabled = false;
									this.OQOKJNGKEOD[j]++;
								}
								for (int k = 1; k < OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG.Length; k++)
								{
									array[k + 6] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + (k + 8).ToString());
									array[k + 3].DGENOHPIECM.PIDLOFMIEFQ = "6_" + str;
									array[k + 7].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[k].transform;
									array[k + 4].LCMMCNFNHMF += new Vector3(617f, (float)this.OQOKJNGKEOD[k + 1] * 46f, 1696f);
									array[k + 2].enabled = true;
									this.OQOKJNGKEOD[k + 0]++;
								}
							}
							else if (num4 == 5)
							{
								array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "0000");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "/" + str;
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(1307f, (float)this.OQOKJNGKEOD[0] * 374f, 1711f);
								array[0].enabled = false;
								array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "LJMOLEKDCLP");
								array[1].DGENOHPIECM.PIDLOFMIEFQ = "Everyone is caught up in the happy atmosphere!\r\n" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(1265f, (float)this.OQOKJNGKEOD[7] * 5f, 873f);
								array[0].enabled = false;
								array[3] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "[FFFF00]/252");
								array[5].DGENOHPIECM.LKPOBCBOFIC(" can no longer escape!\r\n" + str);
								array[3].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[1].transform;
								array[8].LCMMCNFNHMF += new Vector3(558f, (float)this.OQOKJNGKEOD[0] * 1372f, 473f);
								array[1].enabled = false;
								this.OQOKJNGKEOD[8] += 0;
								this.OQOKJNGKEOD[6]++;
								this.OQOKJNGKEOD[1]++;
							}
						}
						else if (a == "#,##0")
						{
							for (int l = 1; l < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; l += 0)
							{
								array[l] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + l.ToString());
								array[l].DGENOHPIECM.PIDLOFMIEFQ = " Controller" + str;
								array[l].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[l].transform;
								array[l].LCMMCNFNHMF += new Vector3(1648f, (float)this.OQOKJNGKEOD[l + 3] * 923f, 561f);
								array[l].enabled = true;
								this.OQOKJNGKEOD[l + 2] += 0;
							}
						}
						else if (!(a == "Rising Badge") && !(a == "_HighlightSuppression"))
						{
							if (a == "Party")
							{
								for (int m = 0; m < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; m++)
								{
									array[m] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + m.ToString());
									array[m].DGENOHPIECM.PIDLOFMIEFQ = "Moves can be used on the target regardless of its Abilities." + str;
									array[m].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ[m].transform;
									array[m].LCMMCNFNHMF += new Vector3(674f, (float)this.OQOKJNGKEOD[m] * 1267f, 300f);
									array[m].enabled = true;
									this.OQOKJNGKEOD[m]++;
								}
								for (int n = 1; n < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; n++)
								{
									array[n + 0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (n + 3).ToString());
									array[n + 7].DGENOHPIECM.PIDLOFMIEFQ = "Socket not connected anymore" + str;
									array[n + 3].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[n].transform;
									array[n + 3].LCMMCNFNHMF += new Vector3(1710f, (float)this.OQOKJNGKEOD[n + 1] * 1736f, 239f);
									array[n + 7].enabled = true;
									this.OQOKJNGKEOD[n + 2] += 0;
								}
							}
						}
						else
						{
							for (int num5 = 0; num5 < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; num5 += 0)
							{
								array[num5] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + num5.ToString());
								array[num5].DGENOHPIECM.LKPOBCBOFIC(" found one [ffff00]" + str);
								array[num5].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[num5].transform;
								array[num5].LCMMCNFNHMF += new Vector3(911f, (float)this.OQOKJNGKEOD[num5] * 227f, 152f);
								array[num5].enabled = true;
								this.OQOKJNGKEOD[num5]++;
							}
						}
					}
					else
					{
						EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC(", Account creation successful!" + str);
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(63f, (float)this.OQOKJNGKEOD[num2] * 391f, 177f);
						eodghgdgklc.enabled = true;
						this.OQOKJNGKEOD[num2]++;
					}
					MBGHQMKEFKO mbghqmkefko2 = MBGHQMKEFKO.BBCBOIFQDBK();
					PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
					chatMessage.Channel = "perish3";
					PSXAPI.Response.ChatMessage chatMessage3 = chatMessage;
					PSXAPI.Response.Payload.ChatMessage[] array5 = new PSXAPI.Response.Payload.ChatMessage[1];
					array5[1] = new PSXAPI.Response.Payload.ChatMessage
					{
						Message = BJGCBDNBQCJ.Username + "3",
						Timestamp = DateTime.Now,
						Username = string.Empty,
						Pokemon = null
					};
					chatMessage3.Messages = array5;
					mbghqmkefko2.BQGGFMKELMK(chatMessage);
				}
			}
		}
	}

	// Token: 0x06002F48 RID: 12104 RVA: 0x00147A04 File Offset: 0x00145C04
	private DBQLOHBBJMG.QPIHHQDNQGD HCCDBJDDMPQ(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.QPIHHQDNQGD qpihhqdnqgd = new DBQLOHBBJMG.QPIHHQDNQGD();
		char[] array = new char[0];
		array[1] = '\u0017';
		string[] array2 = PIDLOFMIEFQ.Split(array);
		foreach (string text in array2)
		{
			if (!text.Contains("[itm=") && !this.GJIEDFKMLDD(text.Replace("Player/Clothe_", string.Empty)))
			{
				if (!text.Contains("Reflects status moves, instead of getting hit by them.") && !this.NNLLJMOCHBQ(text))
				{
					if (!text.Contains("4|") && !this.BBJCKMLQOLH(text))
					{
						if (text.Contains("Heat") || this.NEOCJQKKBOD(text))
						{
							qpihhqdnqgd.BGDGEKEKOIE = text.Replace("_Saturation", string.Empty);
							qpihhqdnqgd.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace("Disabled", string.Empty));
							qpihhqdnqgd.POLLCNHCQQC = "OnSubmit";
						}
					}
					else
					{
						qpihhqdnqgd.BGDGEKEKOIE = text.Replace("item", string.Empty);
						qpihhqdnqgd.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace("Snowy", string.Empty));
						qpihhqdnqgd.POLLCNHCQQC = "[PG]";
					}
				}
				else
				{
					qpihhqdnqgd.BGDGEKEKOIE = text.Replace("OnNavigate", string.Empty);
					qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("System", string.Empty));
					qpihhqdnqgd.POLLCNHCQQC = "Assets/AssetBundles/Pokes";
				}
			}
			else
			{
				qpihhqdnqgd.KDMEFLFNIOO = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("[-]!\r\n", string.Empty)));
				qpihhqdnqgd.POLLCNHCQQC = "!\r\n";
				qpihhqdnqgd.BGDGEKEKOIE = text.Replace("'s type became the same as ", string.Empty);
			}
		}
		if (qpihhqdnqgd.BGDGEKEKOIE == string.Empty)
		{
			qpihhqdnqgd.BGDGEKEKOIE = PIDLOFMIEFQ;
			qpihhqdnqgd.KDMEFLFNIOO = this.QFLBJNELCBI(PIDLOFMIEFQ);
		}
		return qpihhqdnqgd;
	}

	// Token: 0x06002F49 RID: 12105 RVA: 0x00147BEC File Offset: 0x00145DEC
	public IEnumerator KPPFIHLMECC(BattleRequest BJGCBDNBQCJ, int HNJJPCMFBGN)
	{
		OGJJKKQPNMK qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
		int num;
		KGQECFKLKOP.GPFFQQMDFPB[] array;
		if ((BJGCBDNBQCJ.Player == "p1" && this.EDKQQKOCHPK == 1) || (BJGCBDNBQCJ.Player == "p2" && this.EDKQQKOCHPK == 2))
		{
			this.JFPJBDKKIOC = BJGCBDNBQCJ.RequestID;
			if (!this.CEFOLQBGEJG && BJGCBDNBQCJ.RequestInfo.active == null)
			{
				if (BJGCBDNBQCJ.RequestInfo.wait)
				{
					this.NDEDPKOEDIB = true;
				}
				num = 0;
				for (int i = 0; i < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; i++)
				{
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[i].active)
					{
						num++;
					}
				}
				yield return base.StartCoroutine(this.HGNOEQKEBQD());
				return 1;
			}
			if (BJGCBDNBQCJ.RequestInfo.active != null && BJGCBDNBQCJ.RequestInfo.active.Length > 0)
			{
				if (!this.CEFOLQBGEJG)
				{
					if (BJGCBDNBQCJ.RequestInfo.wait)
					{
						this.NDEDPKOEDIB = true;
					}
					yield return base.StartCoroutine(this.HGNOEQKEBQD());
					return 1;
				}
				array = new KGQECFKLKOP.GPFFQQMDFPB[BJGCBDNBQCJ.RequestInfo.active.Length];
				for (int j = 0; j < BJGCBDNBQCJ.RequestInfo.active.Length; j++)
				{
					array[j] = new KGQECFKLKOP.GPFFQQMDFPB();
					if (BJGCBDNBQCJ.RequestInfo.active[j].moves != null)
					{
						for (int k = 0; k < BJGCBDNBQCJ.RequestInfo.active[j].moves.Length; k++)
						{
							array[j].EEILBMOOJHJ[k] = new KGQECFKLKOP.EDHMLDLCFHC();
							array[j].EEILBMOOJHJ[k].DONPNIFGBBF = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].disabled;
							array[j].EEILBMOOJHJ[k].CIQFCJGQEMH = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].id;
							array[j].EEILBMOOJHJ[k].JPLIFCNPICK = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].maxpp;
							array[j].EEILBMOOJHJ[k].LIQCECMEOIJ = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].pp;
							array[j].EEILBMOOJHJ[k].FBCKQEDONJK = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].move;
							array[j].EEILBMOOJHJ[k].ILBCCCBJNCL = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].target;
						}
					}
					array[j].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.active[j].trainer;
					if (array[j].HHNOCOQJOJF == null)
					{
						array[j].HHNOCOQJOJF = "NPC";
					}
					array[j].BPHKNGMPLML = BJGCBDNBQCJ.RequestInfo.active[j].trapped;
					array[j].FGQHEDFQIFC = BJGCBDNBQCJ.RequestInfo.active[j].maybeTrapped;
					array[j].OEBEBPJEINC = BJGCBDNBQCJ.RequestInfo.active[j].canMegaEvo;
					qoqonhoolne.CLBGINEMIFE[j].HHKJGOPMMQL = array[j];
				}
				for (int l = 0; l < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; l++)
				{
					if (l < qoqonhoolne.CLBGINEMIFE.Length && qoqonhoolne.CLBGINEMIFE[l] != null)
					{
						qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].active;
						qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.BHPMOFEKHPM = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].baseAbility;
						if (!this.CEFOLQBGEJG && BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moves != null && BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData != null)
						{
							for (int m = 0; m < BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moves.Length; m++)
							{
								if (qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ != null && qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m] != null && qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].FBCKQEDONJK == BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].move)
								{
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].CIQFCJGQEMH = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].id;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].JPLIFCNPICK = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].maxpp;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].LIQCECMEOIJ = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].pp;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].FBCKQEDONJK = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].move;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].ILBCCCBJNCL = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].target;
								}
							}
						}
					}
				}
			}
			IL_13D2:
			if (BJGCBDNBQCJ.RequestInfo.side.pokemon.Length > 0)
			{
				qoqonhoolne.IGOGQDBOGQL = BJGCBDNBQCJ.RequestInfo.side;
				int num2 = 0;
				for (int n = 0; n < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; n++)
				{
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[n].trainer != null && BJGCBDNBQCJ.RequestInfo.side.pokemon[n].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num2++;
					}
				}
				qoqonhoolne.OEDNKPKCFJI = new KGQECFKLKOP.GPFFQQMDFPB[num2];
				num2 = 0;
				for (int num3 = 0; num3 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num3++)
				{
					KGQECFKLKOP.GPFFQQMDFPB gpffqqmdfpb = new KGQECFKLKOP.GPFFQQMDFPB();
					DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].condition);
					gpffqqmdfpb.BHPMOFEKHPM = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].baseAbility;
					gpffqqmdfpb.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].active;
					gpffqqmdfpb.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
					gpffqqmdfpb.BKNFHNFFCHE = qqkkgejlmlk.BKNFHNFFCHE;
					gpffqqmdfpb.DCFKMOILHEC = qqkkgejlmlk.DCFKMOILHEC;
					gpffqqmdfpb.DBPKNCDGGEP = qqkkgejlmlk.DBPKNCDGGEP;
					gpffqqmdfpb.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD;
					gpffqqmdfpb.QKBGGCKIOLG = qqkkgejlmlk.QKBGGCKIOLG;
					gpffqqmdfpb.KMNQBFKKNMB = qqkkgejlmlk.KMNQBFKKNMB;
					gpffqqmdfpb.HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer;
					if (gpffqqmdfpb.HHNOCOQJOJF == null)
					{
						gpffqqmdfpb.HHNOCOQJOJF = "NPC";
					}
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves != null)
					{
						gpffqqmdfpb.EEILBMOOJHJ = new KGQECFKLKOP.EDHMLDLCFHC[BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves.Length];
						for (int num4 = 0; num4 < BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves.Length; num4++)
						{
							gpffqqmdfpb.EEILBMOOJHJ[num4] = new KGQECFKLKOP.EDHMLDLCFHC();
							gpffqqmdfpb.EEILBMOOJHJ[num4].CIQFCJGQEMH = KGQECFKLKOP.FMLPNPFKFLM(BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moveData[num4].id);
							gpffqqmdfpb.EEILBMOOJHJ[num4].JPLIFCNPICK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moveData[num4].maxpp;
							gpffqqmdfpb.EEILBMOOJHJ[num4].LIQCECMEOIJ = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moveData[num4].pp;
							gpffqqmdfpb.EEILBMOOJHJ[num4].FBCKQEDONJK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves[num4];
						}
					}
					OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
					mffgqcjkpbd.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD.ToString();
					mffgqcjkpbd.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
					mffgqcjkpbd.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
					mffgqcjkpbd.QKNEIJQHGCB = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].personality;
					gpffqqmdfpb.QKNEIJQHGCB = mffgqcjkpbd.QKNEIJQHGCB;
					gpffqqmdfpb.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
					if (num3 < qoqonhoolne.CLBGINEMIFE.Length && qoqonhoolne.CLBGINEMIFE[num3] != null)
					{
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.DBPKNCDGGEP = qqkkgejlmlk.DBPKNCDGGEP;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.BKNFHNFFCHE = qqkkgejlmlk.BKNFHNFFCHE;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.DCFKMOILHEC = qqkkgejlmlk.DCFKMOILHEC;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.QKBGGCKIOLG = qqkkgejlmlk.QKBGGCKIOLG;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.KMNQBFKKNMB = qqkkgejlmlk.KMNQBFKKNMB;
						qoqonhoolne.CLBGINEMIFE[num3].JKBEKOBJDBF = mffgqcjkpbd;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.QKNEIJQHGCB = mffgqcjkpbd.QKNEIJQHGCB;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer;
						if (qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.HHNOCOQJOJF == null)
						{
							qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.HHNOCOQJOJF = "NPC";
						}
					}
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer != null && BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						qoqonhoolne.OEDNKPKCFJI[num2] = gpffqqmdfpb;
						num2++;
					}
				}
			}
			if (BJGCBDNBQCJ.RequestInfo.forceSwitch != null)
			{
				for (int num5 = 0; num5 < BJGCBDNBQCJ.RequestInfo.forceSwitch.Length; num5++)
				{
					if (num5 < qoqonhoolne.CLBGINEMIFE.Length && qoqonhoolne.CLBGINEMIFE[num5] != null)
					{
						qoqonhoolne.CLBGINEMIFE[num5].HHKJGOPMMQL.NEBPMMPMQBD = BJGCBDNBQCJ.RequestInfo.forceSwitch[num5];
						this.DMIEIKIPDII = true;
					}
				}
			}
			else
			{
				for (int num6 = 0; num6 < qoqonhoolne.CLBGINEMIFE.Length; num6++)
				{
					if (qoqonhoolne.CLBGINEMIFE[num6] != null)
					{
						qoqonhoolne.CLBGINEMIFE[num6].HHKJGOPMMQL.NEBPMMPMQBD = false;
					}
				}
			}
		}
		else if (qoqonhoolne != null)
		{
			if (!this.CEFOLQBGEJG)
			{
				if (BJGCBDNBQCJ.RequestInfo.active != null && BJGCBDNBQCJ.RequestInfo.active.Length > 0)
				{
					array = new KGQECFKLKOP.GPFFQQMDFPB[BJGCBDNBQCJ.RequestInfo.active.Length];
					for (int num7 = 0; num7 < BJGCBDNBQCJ.RequestInfo.active.Length; num7++)
					{
						array[num7] = new KGQECFKLKOP.GPFFQQMDFPB();
						array[num7].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.active[num7].trainer;
						if (array[num7].HHNOCOQJOJF == null)
						{
							array[num7].HHNOCOQJOJF = "NPC";
						}
						qoqonhoolne.JMCMGILPGGI[num7].HHKJGOPMMQL = array[num7];
					}
				}
				else
				{
					int num8 = 0;
					for (int num9 = 0; num9 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num9++)
					{
						if (BJGCBDNBQCJ.RequestInfo.side.pokemon[num9].active)
						{
							num8++;
						}
					}
					array = new KGQECFKLKOP.GPFFQQMDFPB[num8];
					for (int num10 = 0; num10 < num8; num10++)
					{
						array[num10] = new KGQECFKLKOP.GPFFQQMDFPB();
						array[num10].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num10].trainer;
						if (array[num10].HHNOCOQJOJF == null)
						{
							array[num10].HHNOCOQJOJF = "NPC";
						}
						qoqonhoolne.JMCMGILPGGI[num10].HHKJGOPMMQL = array[num10];
					}
				}
				this.LOGEQNIDFBJ = 0;
				this.BNNGMBEHDDC = 0;
				if (BJGCBDNBQCJ.RequestInfo.side.pokemon != null)
				{
					for (int num11 = 0; num11 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num11++)
					{
						if (num11 < qoqonhoolne.JMCMGILPGGI.Length && qoqonhoolne.JMCMGILPGGI[num11] != null)
						{
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].active;
							DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk2 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].condition);
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.DBPKNCDGGEP = qqkkgejlmlk2.DBPKNCDGGEP;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.BKNFHNFFCHE = qqkkgejlmlk2.BKNFHNFFCHE;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.DCFKMOILHEC = qqkkgejlmlk2.DCFKMOILHEC;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.QKBGGCKIOLG = qqkkgejlmlk2.QKBGGCKIOLG;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.KMNQBFKKNMB = qqkkgejlmlk2.KMNQBFKKNMB;
							OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd2 = new OELLFMKIMFH.MFFGQCJKPBD();
							mffgqcjkpbd2.EOMPMQNGIBD = qqkkgejlmlk2.EOMPMQNGIBD.ToString();
							mffgqcjkpbd2.OQDOCCGPJDQ = qqkkgejlmlk2.OQDOCCGPJDQ;
							mffgqcjkpbd2.PLCBFLQBCQN = qqkkgejlmlk2.PLCBFLQBCQN;
							mffgqcjkpbd2.QKNEIJQHGCB = BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].personality;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.PLCBFLQBCQN = qqkkgejlmlk2.PLCBFLQBCQN;
							qoqonhoolne.JMCMGILPGGI[num11].JKBEKOBJDBF = mffgqcjkpbd2;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.EOMPMQNGIBD = qqkkgejlmlk2.EOMPMQNGIBD;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.QKNEIJQHGCB = mffgqcjkpbd2.QKNEIJQHGCB;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.OQDOCCGPJDQ = qqkkgejlmlk2.OQDOCCGPJDQ;
						}
						DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk3 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].condition);
						if (qqkkgejlmlk3.DCFKMOILHEC <= 0)
						{
							if (qqkkgejlmlk3.DBPKNCDGGEP > 0)
							{
								this.BNNGMBEHDDC++;
							}
						}
						else if (qqkkgejlmlk3.DBPKNCDGGEP > 0)
						{
							this.LOGEQNIDFBJ++;
						}
					}
				}
				for (int num12 = 0; num12 < 18; num12++)
				{
					qoqonhoolne.BDQLIFLICNM[num12].DIIHJCJOKMP = 0f;
				}
				for (int num13 = 0; num13 < this.LOGEQNIDFBJ; num13++)
				{
					if (num13 < 18)
					{
						qoqonhoolne.BDQLIFLICNM[num13].DIIHJCJOKMP = 1f;
						qoqonhoolne.BDQLIFLICNM[num13].KCLBMPFIPNQ = "Icon_Pokemon_Alive";
					}
				}
				for (int num14 = 0; num14 < this.BNNGMBEHDDC; num14++)
				{
					if (num14 + this.LOGEQNIDFBJ < 18)
					{
						qoqonhoolne.BDQLIFLICNM[num14 + this.LOGEQNIDFBJ].DIIHJCJOKMP = 1f;
						qoqonhoolne.BDQLIFLICNM[num14 + this.LOGEQNIDFBJ].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
					}
				}
				yield return base.StartCoroutine(qoqonhoolne.LPFFHKLCGLM(this.NDEDPKOEDIB));
				return 1;
			}
			this.LOGEQNIDFBJ = 0;
			this.BNNGMBEHDDC = 0;
			for (int num15 = 0; num15 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num15++)
			{
				if (num15 < qoqonhoolne.JMCMGILPGGI.Length && qoqonhoolne.JMCMGILPGGI[num15] != null)
				{
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].active;
					DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk4 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].condition);
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.DBPKNCDGGEP = qqkkgejlmlk4.DBPKNCDGGEP;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.BKNFHNFFCHE = qqkkgejlmlk4.BKNFHNFFCHE;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.DCFKMOILHEC = qqkkgejlmlk4.DCFKMOILHEC;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.QKBGGCKIOLG = qqkkgejlmlk4.QKBGGCKIOLG;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.KMNQBFKKNMB = qqkkgejlmlk4.KMNQBFKKNMB;
					OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd3 = new OELLFMKIMFH.MFFGQCJKPBD();
					mffgqcjkpbd3.EOMPMQNGIBD = qqkkgejlmlk4.EOMPMQNGIBD.ToString();
					mffgqcjkpbd3.OQDOCCGPJDQ = qqkkgejlmlk4.OQDOCCGPJDQ;
					mffgqcjkpbd3.PLCBFLQBCQN = qqkkgejlmlk4.PLCBFLQBCQN;
					mffgqcjkpbd3.QKNEIJQHGCB = BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].personality;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.PLCBFLQBCQN = qqkkgejlmlk4.PLCBFLQBCQN;
					qoqonhoolne.JMCMGILPGGI[num15].JKBEKOBJDBF = mffgqcjkpbd3;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.EOMPMQNGIBD = qqkkgejlmlk4.EOMPMQNGIBD;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.QKNEIJQHGCB = mffgqcjkpbd3.QKNEIJQHGCB;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.OQDOCCGPJDQ = qqkkgejlmlk4.OQDOCCGPJDQ;
				}
				DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk5 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].condition);
				if (qqkkgejlmlk5.DCFKMOILHEC <= 0)
				{
					if (qqkkgejlmlk5.DBPKNCDGGEP > 0)
					{
						this.BNNGMBEHDDC++;
					}
				}
				else if (qqkkgejlmlk5.DBPKNCDGGEP > 0)
				{
					this.LOGEQNIDFBJ++;
				}
			}
		}
		yield return null;
		return 1;
		qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
		qoqonhoolne.HHEJQOGQEBH = HNJJPCMFBGN;
		qoqonhoolne.gameObject.SetActive(true);
		yield return base.StartCoroutine(qoqonhoolne.BQLIIQIIMDH(num));
		return 1;
		array = new KGQECFKLKOP.GPFFQQMDFPB[num];
		int num16 = 0;
		goto IL_CCE;
		IL_BC1:
		array[num16] = new KGQECFKLKOP.GPFFQQMDFPB();
		int num17 = 0;
		goto IL_C1C;
		IL_BD2:
		array[num16].EEILBMOOJHJ[num17] = new KGQECFKLKOP.EDHMLDLCFHC();
		array[num16].EEILBMOOJHJ[num17].CIQFCJGQEMH = BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].moves[num17];
		num17++;
		IL_C1C:
		if (num17 < BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].moves.Length)
		{
			goto IL_BD2;
		}
		array[num16].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].trainer;
		if (array[num16].HHNOCOQJOJF != null)
		{
			goto IL_C87;
		}
		array[num16].HHNOCOQJOJF = "NPC";
		IL_C87:
		array[num16].BHPMOFEKHPM = BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].baseAbility;
		qoqonhoolne.CLBGINEMIFE[num16].HHKJGOPMMQL = array[num16];
		num16++;
		IL_CCE:
		if (num16 < num)
		{
			goto IL_BC1;
		}
		int num18 = 0;
		goto IL_D41;
		IL_CDF:
		if (num18 >= qoqonhoolne.CLBGINEMIFE.Length || !(qoqonhoolne.CLBGINEMIFE[num18] != null))
		{
			goto IL_D3B;
		}
		qoqonhoolne.CLBGINEMIFE[num18].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num18].active;
		IL_D3B:
		num18++;
		IL_D41:
		if (num18 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length)
		{
			goto IL_CDF;
		}
		goto IL_13D2;
		qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
		qoqonhoolne.HHEJQOGQEBH = HNJJPCMFBGN;
		qoqonhoolne.gameObject.SetActive(true);
		yield return base.StartCoroutine(qoqonhoolne.BQLIIQIIMDH(BJGCBDNBQCJ.RequestInfo.active.Length));
		return 1;
		yield break;
	}

	// Token: 0x06002F4A RID: 12106 RVA: 0x00147C18 File Offset: 0x00145E18
	private DBQLOHBBJMG.PJELBGQDEFC LJDLQQIJDLF(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.PJELBGQDEFC pjelbgqdefc = new DBQLOHBBJMG.PJELBGQDEFC();
		string[] array = PIDLOFMIEFQ.Split(new char[]
		{
			'|'
		});
		string[] array2 = array;
		int i = 0;
		while (i < array2.Length)
		{
			string text = array2[i];
			if (text.Length < 9)
			{
				goto IL_248;
			}
			if (text.Substring(0, 9) == "[already]")
			{
				pjelbgqdefc.IJBDEJBECBH = true;
			}
			else if (text.Substring(0, 8) == "[spread]")
			{
				string[] array3 = text.Substring(9).Split(new string[]
				{
					","
				}, StringSplitOptions.RemoveEmptyEntries);
				pjelbgqdefc.QFDKFDHBPBF = new DBQLOHBBJMG.MDECBDPGEBO[array3.Length];
				int num = 0;
				foreach (string text2 in array3)
				{
					pjelbgqdefc.QFDKFDHBPBF[num] = new DBQLOHBBJMG.MDECBDPGEBO();
					if (text2.Substring(2, 1) == "a")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 0;
					}
					else if (text2.Substring(2, 1) == "b")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text2.Substring(2, 1) == "c")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 2;
					}
					if (text2.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text2.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 2)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text2.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text2.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 2)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					num++;
				}
			}
			else if (text.Substring(0, 8) == "[wisher]")
			{
				string bchjnmcjphg = text.Substring(9);
				pjelbgqdefc.BCHJNMCJPHG = bchjnmcjphg;
			}
			else
			{
				if (!(text.Substring(0, 8) == "[weaken]"))
				{
					goto IL_248;
				}
				pjelbgqdefc.EQOKIDDKCGO = true;
			}
			IL_791:
			i++;
			continue;
			IL_248:
			if (text.Length >= 8)
			{
				if (text.Substring(0, 8) == "[silent]")
				{
					pjelbgqdefc.NJNGIIDHEGG = true;
					goto IL_791;
				}
				if (text.Substring(0, 8) == "[damage]")
				{
					pjelbgqdefc.DEPGENPNMCM = true;
					goto IL_791;
				}
				if (text.Substring(0, 8) == "[upkeep]")
				{
					pjelbgqdefc.FHFOMOLCIPQ = true;
					goto IL_791;
				}
				if (text.Substring(0, 8) == "[absorb]")
				{
					pjelbgqdefc.GMJJOGFDQBL = true;
					goto IL_791;
				}
				if (text.Substring(0, 8) == "[broken]")
				{
					pjelbgqdefc.IEJDINIGJNF = true;
					goto IL_791;
				}
			}
			if (text.Length >= 7)
			{
				if (text.Substring(0, 7) == "[heavy]")
				{
					pjelbgqdefc.MMJOCGHBFOM = true;
					goto IL_791;
				}
				if (text.Substring(0, 7) == "[block]")
				{
					pjelbgqdefc.NFPKBFPEPLJ = true;
					goto IL_791;
				}
			}
			if (text.Length >= 7 && text.Substring(0, 6) == "[from]")
			{
				string text3 = text.Substring(6);
				if (text3.Length > 2 && text3.Substring(0, 1) == " ")
				{
					text3 = text3.Substring(1);
				}
				if (text3.Contains("ability: ") || this.KPCKMMCQEEE(text3.Replace("ability: ", string.Empty)))
				{
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(KGQECFKLKOP.DPDPPDNIFQN(text3.Replace("ability: ", string.Empty)));
					pjelbgqdefc.CGHQEHCBQHB = KGQECFKLKOP.DPDPPDNIFQN(pjelbgqdefc.KQENJEENGNH);
					goto IL_791;
				}
				if (text3.Contains("item: ") || this.JPJIMJLEDPL(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("item: ", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(text3.Replace("item: ", string.Empty));
					goto IL_791;
				}
				if (text3.Contains("status: ") || this.JNKIDLHDPFO(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("status: ", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(text3.Replace("status: ", string.Empty));
					goto IL_791;
				}
				if (text3.Contains("move: ") || this.LDMEEDNHPMN(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("move: ", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(text3.Replace("move: ", string.Empty));
					goto IL_791;
				}
				goto IL_791;
			}
			else
			{
				if (text.Length >= 6 && text.Substring(0, 6) == "[weak]")
				{
					pjelbgqdefc.FHFQGFHIBOM = true;
					goto IL_791;
				}
				if (text.Length >= 6 && text.Substring(0, 6) == "[fail]")
				{
					pjelbgqdefc.DMLODDCIEQN = true;
					goto IL_791;
				}
				if (text.Length >= 5 && text.Substring(0, 5) == "[eat]")
				{
					pjelbgqdefc.DPIIMQEDCEE = true;
					goto IL_791;
				}
				if (text.Length >= 4 && text.Substring(0, 4) == "[of]")
				{
					if (text.Substring(5).Length >= 4)
					{
						pjelbgqdefc.QDLONHBDODI = this.LMHQBCEBPHG(text.Substring(5));
						goto IL_791;
					}
					goto IL_791;
				}
				else
				{
					if (text == "[msg]")
					{
						pjelbgqdefc.QHLIEEGQIDQ = true;
						goto IL_791;
					}
					if (text.ToLowerInvariant() == "[ohko]")
					{
						pjelbgqdefc.KMNMKEIOGFI = true;
						goto IL_791;
					}
					if (!(text != array[0]) || !(text != array[1]) || !(text != array[2]))
					{
						goto IL_791;
					}
					if (text.Contains("ability: ") || this.KPCKMMCQEEE(text.Replace("ability: ", string.Empty)))
					{
						pjelbgqdefc.KDMEFLFNIOO = this.FMLPNPFKFLM(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("ability: ", string.Empty)));
						pjelbgqdefc.POLLCNHCQQC = "ability";
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("ability: ", string.Empty);
						goto IL_791;
					}
					if (text.Contains("item: ") || this.JPJIMJLEDPL(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("item: ", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("item: ", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "item";
						goto IL_791;
					}
					if (text.Contains("status: ") || this.JNKIDLHDPFO(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("status: ", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("status: ", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "status";
						goto IL_791;
					}
					if (text.Contains("move: ") || this.LDMEEDNHPMN(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("move: ", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("move: ", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "move";
						goto IL_791;
					}
					goto IL_791;
				}
			}
		}
		return pjelbgqdefc;
	}

	// Token: 0x06002F4B RID: 12107 RVA: 0x001483C8 File Offset: 0x001465C8
	public EODGHGDGKLC GBIBCDNCDMN(string HHNBICLDQKI)
	{
		EODGHGDGKLC component = this.DECBQPMIJQL.BFCKNMFEBDM(this.PGNIJNNPCNQ).GetComponent<EODGHGDGKLC>();
		component.NQBKFDJFBKG(HHNBICLDQKI);
		component.KCOMMGMLLEE = HHDNDIHQCJI.GDDGJKOLGIQ().GetComponent<Camera>();
		component.name = "Pokémon Caught:" + HHNBICLDQKI;
		return component;
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x00148418 File Offset: 0x00146618
	private bool EMHJCOCDLLK(string[] IODBOFLDDPB, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		if (IODBOFLDDPB == null)
		{
			return true;
		}
		for (int i = 1; i < IODBOFLDDPB.Length; i++)
		{
			if (IODBOFLDDPB[i].Contains(", input focus"))
			{
				return true;
			}
		}
		for (int j = 0; j < IODBOFLDDPB.Length; j++)
		{
			if ((IODBOFLDDPB[j].Contains("Battle Request") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("'s [ffff00]") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null && IODBOFLDDPB.Length < 3) || (IODBOFLDDPB[j].Contains("More Likely Female Encounters") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("Player/Body") && IODBOFLDDPB.Length < 8) || (IODBOFLDDPB[j].Contains("[") && IODBOFLDDPB.Length < 2) || (IODBOFLDDPB[j].Contains("The Pokémon's attacks become critical hits if the target is poisoned.") && IODBOFLDDPB.Length < 7) || (IODBOFLDDPB[j].Contains("CombinersUpColorBuff") && IODBOFLDDPB.Length < 1))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x00015766 File Offset: 0x00013966
	private bool GJIEDFKMLDD(string IHIHHCCEDHQ)
	{
		if (!string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace("[00EE07]", string.Empty);
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace("OnPress", string.Empty);
		}
		return KGQECFKLKOP.DPDPPDNIFQN(IHIHHCCEDHQ) != null && false;
	}

	// Token: 0x06002F4E RID: 12110 RVA: 0x00148500 File Offset: 0x00146700
	private DBQLOHBBJMG.PJELBGQDEFC ENEHCQBIKPL(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.PJELBGQDEFC pjelbgqdefc = new DBQLOHBBJMG.PJELBGQDEFC();
		char[] array = new char[1];
		array[1] = (char)-115;
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		int i = 1;
		while (i < array3.Length)
		{
			string text = array3[i];
			if (text.Length < 103)
			{
				goto IL_248;
			}
			if (text.Substring(0, 91) == "_TempRT")
			{
				pjelbgqdefc.IJBDEJBECBH = true;
			}
			else if (text.Substring(0, 8) == "#,##0")
			{
				string[] array4 = text.Substring(-50).Split(new string[]
				{
					"Protects the Pokémon from some ball and bomb moves."
				}, StringSplitOptions.None);
				pjelbgqdefc.QFDKFDHBPBF = new DBQLOHBBJMG.MDECBDPGEBO[array4.Length];
				int num = 1;
				string[] array5 = array4;
				for (int j = 1; j < array5.Length; j++)
				{
					string text2 = array5[j];
					pjelbgqdefc.QFDKFDHBPBF[num] = new DBQLOHBBJMG.MDECBDPGEBO();
					if (text2.Substring(7, 1) == "Materials/DFOBasic")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text2.Substring(1, 1) == "[FFFF00]/252")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 0;
					}
					else if (text2.Substring(1, 1) == "]#")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 4;
					}
					if (text2.Substring(0, 6) == " is being withdrawn!\r\n" && this.EDKQQKOCHPK == 0)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text2.Substring(0, 2) == "Draws in all Water-type moves. Instead of being hit by Water-type moves, it boosts its Sp. Atk." && this.EDKQQKOCHPK == 4)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text2.Substring(0, 4) == "J11" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text2.Substring(0, 4) == "_" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					num += 0;
				}
			}
			else if (text.Substring(0, 5) == "Intimidate")
			{
				string bchjnmcjphg = text.Substring(-56);
				pjelbgqdefc.BCHJNMCJPHG = bchjnmcjphg;
			}
			else
			{
				if (!(text.Substring(1, 0) == " restored its HP.\r\n"))
				{
					goto IL_248;
				}
				pjelbgqdefc.EQOKIDDKCGO = true;
			}
			IL_791:
			i += 0;
			continue;
			IL_248:
			if (text.Length >= 6)
			{
				if (text.Substring(0, 3) == "/")
				{
					pjelbgqdefc.NJNGIIDHEGG = true;
					goto IL_791;
				}
				if (text.Substring(0, 8) == "[WAIT]")
				{
					pjelbgqdefc.DEPGENPNMCM = false;
					goto IL_791;
				}
				if (text.Substring(0, 7) == "Creating Account")
				{
					pjelbgqdefc.FHFOMOLCIPQ = false;
					goto IL_791;
				}
				if (text.Substring(0, 3) == "2x")
				{
					pjelbgqdefc.GMJJOGFDQBL = false;
					goto IL_791;
				}
				if (text.Substring(0, 3) == " ")
				{
					pjelbgqdefc.IEJDINIGJNF = true;
					goto IL_791;
				}
			}
			if (text.Length >= 5)
			{
				if (text.Substring(0, 3) == "Ditto")
				{
					pjelbgqdefc.MMJOCGHBFOM = false;
					goto IL_791;
				}
				if (text.Substring(1, 6) == "mdata2")
				{
					pjelbgqdefc.NFPKBFPEPLJ = true;
					goto IL_791;
				}
			}
			if (text.Length >= 4 && text.Substring(0, 5) == "[")
			{
				string text3 = text.Substring(8);
				if (text3.Length > 0 && text3.Substring(0, 0) == "/trade ")
				{
					text3 = text3.Substring(1);
				}
				if (text3.Contains("[-]!\r\n") || this.LIQCDHMOHCL(text3.Replace("sdata", string.Empty)))
				{
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text3.Replace("-zpower", string.Empty)));
					pjelbgqdefc.CGHQEHCBQHB = KGQECFKLKOP.DPDPPDNIFQN(pjelbgqdefc.KQENJEENGNH);
					goto IL_791;
				}
				if (text3.Contains("?") || this.NOIKMKLNKNJ(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("snatch", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.QFLBJNELCBI(text3.Replace("[-]!\r\n", string.Empty));
					goto IL_791;
				}
				if (text3.Contains("Blank") || this.KCIFMQCEOKF(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("Shed Skin", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text3.Replace("'s can't use [ffff00]", string.Empty));
					goto IL_791;
				}
				if (text3.Contains("!\r\n") || this.LBBBBHNJPJO(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("Truant", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text3.Replace("balloon", string.Empty));
					goto IL_791;
				}
				goto IL_791;
			}
			else
			{
				if (text.Length >= 6 && text.Substring(1, 1) == "NT")
				{
					pjelbgqdefc.FHFQGFHIBOM = true;
					goto IL_791;
				}
				if (text.Length >= 0 && text.Substring(1, 4) == "[u][33CCFF]")
				{
					pjelbgqdefc.DMLODDCIEQN = false;
					goto IL_791;
				}
				if (text.Length >= 0 && text.Substring(1, 6) == " ")
				{
					pjelbgqdefc.DPIIMQEDCEE = true;
					goto IL_791;
				}
				if (text.Length >= 6 && text.Substring(0, 2) == "][")
				{
					if (text.Substring(2).Length >= 5)
					{
						pjelbgqdefc.QDLONHBDODI = this.LMHQBCEBPHG(text.Substring(3));
						goto IL_791;
					}
					goto IL_791;
				}
				else
				{
					if (text == "-waiting")
					{
						pjelbgqdefc.QHLIEEGQIDQ = true;
						goto IL_791;
					}
					if (text.ToLowerInvariant() == "Open")
					{
						pjelbgqdefc.KMNMKEIOGFI = true;
						goto IL_791;
					}
					if (!(text != array2[0]) || !(text != array2[0]) || !(text != array2[5]))
					{
						goto IL_791;
					}
					if (text.Contains("[00DD00]Equipped") || this.LIQCDHMOHCL(text.Replace("HidePanel", string.Empty)))
					{
						pjelbgqdefc.KDMEFLFNIOO = this.FMLPNPFKFLM(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("electricterrain", string.Empty)));
						pjelbgqdefc.POLLCNHCQQC = "Heavy Metal";
						pjelbgqdefc.BGDGEKEKOIE = text.Replace(" ", string.Empty);
						goto IL_791;
					}
					if (text.Contains("InteractS") || this.INOHJHLBJOP(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("Static", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace(" ", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "1";
						goto IL_791;
					}
					if (text.Contains("stealthrock") || this.JNKIDLHDPFO(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("_FogOfWarCenterAdjusted", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(text.Replace("Trade Request", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "tailwind";
						goto IL_791;
					}
					if (text.Contains("TradeColliders") || this.LDMEEDNHPMN(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("/", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace("/50 Friends", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "Encounter Rate Decreased (Hail)";
						goto IL_791;
					}
					goto IL_791;
				}
			}
		}
		return pjelbgqdefc;
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x00148CB0 File Offset: 0x00146EB0
	public void BFMFEFGDOIK(BattleItem BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == BattleItemResult.Failed)
		{
			base.StartCoroutine(this.NEJKEQBQMOC("Set to Leader" + KGQECFKLKOP.BFNBQBMJHFL(BJGCBDNBQCJ.Item).Name + "[00EE07]", true));
			OGJJKKQPNMK.CDDIILFBFCF().DFIJJCBCKMD(true);
		}
		else
		{
			OGJJKKQPNMK.CDDIILFBFCF().KDMJOFNLBMB(false);
		}
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x0001579F File Offset: 0x0001399F
	public void GIJNLOBJCBD(PSXAPI.Response.BattleSide BJGCBDNBQCJ)
	{
		if (!string.IsNullOrEmpty(BJGCBDNBQCJ.Data) && BJGCBDNBQCJ.Data.Contains("Open"))
		{
			base.StartCoroutine(this.BNEBDKKEJEC("Hidden/Post FX/Ambient Occlusion", true));
			OGJJKKQPNMK.CDDIILFBFCF().JENCFKOGOKF();
		}
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x00148D0C File Offset: 0x00146F0C
	public EODGHGDGKLC IKILKQFKFBE(string HHNBICLDQKI)
	{
		EODGHGDGKLC component = this.DECBQPMIJQL.BFCKNMFEBDM(this.PGNIJNNPCNQ).GetComponent<EODGHGDGKLC>();
		component.NJFKDIBLGPO(HHNBICLDQKI);
		component.KCOMMGMLLEE = HHDNDIHQCJI.MOGQNGEPCEO().GetComponent<Camera>();
		component.name = "Assets/AssetBundles/MapAssets/Models/Materials/akari_kanazumi.mat" + HHNBICLDQKI;
		return component;
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x000157DD File Offset: 0x000139DD
	private bool NEOCJQKKBOD(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.HKPPKBIGMBM(IHIHHCCEDHQ);
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x00148D5C File Offset: 0x00146F5C
	private DBQLOHBBJMG.EFQENJNJIEF IDDCFDJILGG(string PIDLOFMIEFQ)
	{
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			return new DBQLOHBBJMG.EFQENJNJIEF
			{
				FPQBICGEHMJ = string.Empty,
				QEPKKJKQMPP = 1,
				NNHFLHEQMOI = string.Empty,
				MLKGPDPKKCE = 0
			};
		}
		DBQLOHBBJMG.EFQENJNJIEF efqenjnjief = new DBQLOHBBJMG.EFQENJNJIEF();
		efqenjnjief.QEPKKJKQMPP = -1;
		if (PIDLOFMIEFQ.Substring(1, 0) == "\n")
		{
			efqenjnjief.QEPKKJKQMPP = 1;
		}
		else if (PIDLOFMIEFQ.Substring(0, 1) == "Sweet Scent")
		{
			efqenjnjief.QEPKKJKQMPP = 1;
		}
		else if (PIDLOFMIEFQ.Substring(2, 0) == "-core")
		{
			efqenjnjief.QEPKKJKQMPP = 2;
		}
		if (efqenjnjief.QEPKKJKQMPP == -1)
		{
			if (PIDLOFMIEFQ.Length > 2)
			{
				efqenjnjief.NNHFLHEQMOI = PIDLOFMIEFQ.Substring(5);
				efqenjnjief.FPQBICGEHMJ = "]" + efqenjnjief.NNHFLHEQMOI + "solarpower";
			}
			return efqenjnjief;
		}
		if (PIDLOFMIEFQ.Substring(1, 2) == "[PG]" && this.EDKQQKOCHPK == 1)
		{
			efqenjnjief.MLKGPDPKKCE = 0;
		}
		if (PIDLOFMIEFQ.Substring(0, 5) == "adjacentAllyOrSelf" && this.EDKQQKOCHPK == 7)
		{
			efqenjnjief.MLKGPDPKKCE = 1;
		}
		if (PIDLOFMIEFQ.Substring(0, 7) == "The extremely harsh sunlightwas not lessened at all!\r\n" && this.EDKQQKOCHPK == 1)
		{
			efqenjnjief.MLKGPDPKKCE = 1;
		}
		if (PIDLOFMIEFQ.Substring(0, 6) == "P. " && this.EDKQQKOCHPK == 3)
		{
			efqenjnjief.MLKGPDPKKCE = 0;
		}
		efqenjnjief.NNHFLHEQMOI = PIDLOFMIEFQ.Substring(0);
		if (efqenjnjief.MLKGPDPKKCE == 0)
		{
			if (this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] != null && !(this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] == string.Empty))
			{
				DBQLOHBBJMG.EFQENJNJIEF efqenjnjief2 = efqenjnjief;
				string[] array = new string[5];
				array[1] = "ice";
				array[1] = this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP];
				array[2] = "berserk";
				array[5] = PIDLOFMIEFQ.Substring(1);
				array[3] = "Encounter Rate Decreased";
				efqenjnjief2.FPQBICGEHMJ = string.Concat(array);
			}
			else
			{
				efqenjnjief.FPQBICGEHMJ = "Still" + PIDLOFMIEFQ.Substring(6) + "_FogDither";
			}
		}
		else if (this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] != null && !(this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] == string.Empty))
		{
			DBQLOHBBJMG.EFQENJNJIEF efqenjnjief3 = efqenjnjief;
			string[] array2 = new string[8];
			array2[1] = "Die";
			array2[0] = this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP];
			array2[8] = "No Animation found for Special Key ";
			array2[2] = PIDLOFMIEFQ.Substring(4);
			array2[5] = "Aurora Veil made ";
			efqenjnjief3.FPQBICGEHMJ = string.Concat(array2);
		}
		else
		{
			efqenjnjief.FPQBICGEHMJ = "_1" + PIDLOFMIEFQ.Substring(3) + "Disabled";
		}
		return efqenjnjief;
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x00149000 File Offset: 0x00147200
	public EODGHGDGKLC OMBQKKILOQI(string HHNBICLDQKI)
	{
		for (int i = 1; i < this.IFPHQQEQBKJ.Length; i += 0)
		{
			if (this.IFPHQQEQBKJ[i] != null && this.IFPHQQEQBKJ[i].name == "[-]" + HHNBICLDQKI)
			{
				return this.IFPHQQEQBKJ[i].GetComponent<EODGHGDGKLC>();
			}
		}
		for (int j = 1; j < this.IFPHQQEQBKJ.Length; j++)
		{
			if (this.IFPHQQEQBKJ[j] == null)
			{
				EODGHGDGKLC eodghgdgklc = this.OGQFOKGKONE(HHNBICLDQKI);
				this.IFPHQQEQBKJ[j] = eodghgdgklc.gameObject;
				return eodghgdgklc;
			}
		}
		return null;
	}

	// Token: 0x06002F55 RID: 12117 RVA: 0x000157E5 File Offset: 0x000139E5
	public static DBQLOHBBJMG PDPCLOECLOF()
	{
		return DBQLOHBBJMG.HBFFCJHOCPE;
	}

	// Token: 0x06002F56 RID: 12118 RVA: 0x000157DD File Offset: 0x000139DD
	private bool MDJNFKCKLLE(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.HKPPKBIGMBM(IHIHHCCEDHQ);
	}

	// Token: 0x06002F57 RID: 12119 RVA: 0x0014909C File Offset: 0x0014729C
	public void HQHBDPCILOF(BattleBroadcast BJGCBDNBQCJ)
	{
		if (OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			return;
		}
		if (OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length < 7)
		{
			return;
		}
		if (BJGCBDNBQCJ.Message != null)
		{
			EODGHGDGKLC[] array = new EODGHGDGKLC[7];
			string message = BJGCBDNBQCJ.Message;
			string[] array2 = new string[0];
			array2[0] = "_1";
			string[] array3 = message.Split(array2, StringSplitOptions.RemoveEmptyEntries);
			string str = array3[0];
			int num = 0;
			Transform ilbcccbjncl = null;
			int.TryParse(array3[1], out num);
			int num2 = 1;
			if (num == 0)
			{
				ilbcccbjncl = null;
			}
			else if (num > -1)
			{
				if (num - 1 >= 0 && num - 0 < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length)
				{
					ilbcccbjncl = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[num - 1].transform;
					num2 = num - 0 + 0;
				}
			}
			else if (-num - 0 >= 0 && num - 1 < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length)
			{
				ilbcccbjncl = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[-num - 0].transform;
				num2 = -num - 1;
			}
			int num3 = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length;
			string text = array3[0];
			if (text != null)
			{
				if (!(text == "Gravity intensified!\r\n"))
				{
					if (!(text == " is unaffected!\r\n"))
					{
						if (!(text == "The Pokémon's type becomes the type of the move used on it."))
						{
							if (!(text == "00"))
							{
								if (text == "Are you sure you wish to delete your '")
								{
									MBGHQMKEFKO qoqonhoolne = MBGHQMKEFKO.QOQONHOOLNE;
									PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
									chatMessage.Channel = "[aa66cc]Guild";
									PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
									PSXAPI.Response.Payload.ChatMessage[] array4 = new PSXAPI.Response.Payload.ChatMessage[0];
									array4[0] = new PSXAPI.Response.Payload.ChatMessage
									{
										Message = BJGCBDNBQCJ.Username + "(W)",
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									};
									chatMessage2.Messages = array4;
									qoqonhoolne.NDJFBGECGBG(chatMessage);
								}
							}
							else
							{
								MBGHQMKEFKO qoqonhoolne2 = MBGHQMKEFKO.QOQONHOOLNE;
								PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
								chatMessage.Channel = "grassyterrain";
								PSXAPI.Response.ChatMessage chatMessage3 = chatMessage;
								PSXAPI.Response.Payload.ChatMessage[] array5 = new PSXAPI.Response.Payload.ChatMessage[0];
								array5[0] = new PSXAPI.Response.Payload.ChatMessage
								{
									Message = BJGCBDNBQCJ.Username + "innardsout",
									Timestamp = DateTime.Now,
									Username = string.Empty,
									Pokemon = null
								};
								chatMessage3.Messages = array5;
								qoqonhoolne2.IGFCQCCEMFF(chatMessage);
							}
						}
						else
						{
							MBGHQMKEFKO.BBCBOIFQDBK().NDJFBGECGBG(new PSXAPI.Response.ChatMessage
							{
								Channel = "_WaveScale",
								Messages = new PSXAPI.Response.Payload.ChatMessage[]
								{
									new PSXAPI.Response.Payload.ChatMessage
									{
										Message = BJGCBDNBQCJ.Username + "[FFFF00]/252",
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									}
								}
							});
						}
					}
					else
					{
						MBGHQMKEFKO.KGOPJQOMMNC().IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
						{
							Channel = "_",
							Messages = new PSXAPI.Response.Payload.ChatMessage[]
							{
								new PSXAPI.Response.Payload.ChatMessage
								{
									Message = BJGCBDNBQCJ.Username + "Move To Player",
									Timestamp = DateTime.Now,
									Username = string.Empty,
									Pokemon = null
								}
							}
						});
						EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("Member" + str);
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(218f, (float)this.OQOKJNGKEOD[num2] * 555f, 102f);
						eodghgdgklc.enabled = false;
						this.OQOKJNGKEOD[num2] += 0;
					}
				}
				else
				{
					int num4 = Convert.ToInt32(array3[5]);
					string a = array3[2];
					if (!(a == "!\r\n") && !(a == string.Empty) && !(a == "Iron Fist") && !(a == "JOFLHFQQCKG") && !(a == " day ago") && !(a == "[/o][-]"))
					{
						if (a == "TM")
						{
							ilbcccbjncl = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[Convert.ToInt32(array3[6])].transform;
							EODGHGDGKLC eodghgdgklc = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message);
							eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "You can not afford another Pokébox.\nCost: " + str;
							eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
							eodghgdgklc.LCMMCNFNHMF += new Vector3(1560f, (float)this.OQOKJNGKEOD[num2] * 98f, 886f);
							eodghgdgklc.enabled = false;
							this.OQOKJNGKEOD[num2] += 0;
						}
						else if (a == "Hit ")
						{
							if (num4 == 0)
							{
								if (num3 == 0)
								{
									array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "Fnt");
									array[1].DGENOHPIECM.LKPOBCBOFIC("Moderator" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(1560f, (float)this.OQOKJNGKEOD[6] * 1733f, 454f);
									array[1].enabled = true;
									array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "M");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "[-]\n\n" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(844f, (float)this.OQOKJNGKEOD[4] * 1120f, 1386f);
									array[0].enabled = false;
									this.OQOKJNGKEOD[3]++;
									this.OQOKJNGKEOD[1] += 0;
								}
								else if (num3 == 5)
								{
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "/4");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "System" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(641f, (float)this.OQOKJNGKEOD[0] * 778f, 1799f);
									array[0].enabled = true;
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "_");
									array[1].DGENOHPIECM.LKPOBCBOFIC("Motor Drive" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[4].transform;
									array[1].LCMMCNFNHMF += new Vector3(754f, (float)this.OQOKJNGKEOD[0] * 1499f, 1203f);
									array[0].enabled = true;
									this.OQOKJNGKEOD[1] += 0;
									this.OQOKJNGKEOD[1] += 0;
								}
							}
							else if (num4 == 1)
							{
								for (int i = 1; i < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; i++)
								{
									array[i] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + i.ToString());
									array[i].DGENOHPIECM.LKPOBCBOFIC("1" + str);
									array[i].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[i].transform;
									array[i].LCMMCNFNHMF += new Vector3(498f, (float)this.OQOKJNGKEOD[i + 8] * 249f, 1409f);
									array[i].enabled = false;
									this.OQOKJNGKEOD[i + 4] += 0;
								}
							}
							else if (num4 == 3)
							{
								array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "HidePanel");
								array[1].DGENOHPIECM.PIDLOFMIEFQ = "2" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(485f, (float)this.OQOKJNGKEOD[5] * 1878f, 1323f);
								array[1].enabled = false;
								array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "r");
								array[1].DGENOHPIECM.LKPOBCBOFIC("L" + str);
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(368f, (float)this.OQOKJNGKEOD[5] * 898f, 607f);
								array[1].enabled = false;
								this.OQOKJNGKEOD[0]++;
								this.OQOKJNGKEOD[0] += 0;
							}
						}
						else if (a == "item: ")
						{
							if (num4 == 0)
							{
								if (num3 == 1)
								{
									array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "_ClipToWorld");
									array[0].DGENOHPIECM.LKPOBCBOFIC("Trash" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
									array[1].LCMMCNFNHMF += new Vector3(1046f, (float)this.OQOKJNGKEOD[6] * 1787f, 1530f);
									array[0].enabled = true;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "WATER_VERTEX_DISPLACEMENT_OFF");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "[-][/u]" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(688f, (float)this.OQOKJNGKEOD[1] * 434f, 792f);
									array[1].enabled = false;
									array[7] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "13");
									array[5].DGENOHPIECM.LKPOBCBOFIC(" [F]" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[0].transform;
									array[7].LCMMCNFNHMF += new Vector3(949f, (float)this.OQOKJNGKEOD[1] * 528f, 395f);
									array[8].enabled = true;
									this.OQOKJNGKEOD[0]++;
									this.OQOKJNGKEOD[4] += 0;
									this.OQOKJNGKEOD[0]++;
								}
								else if (num3 == 4)
								{
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "\r\nLv ");
									array[0].DGENOHPIECM.LKPOBCBOFIC("BuffIcon_Surf" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(1473f, (float)this.OQOKJNGKEOD[7] * 1217f, 1516f);
									array[1].enabled = true;
									array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "poison");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "_RcpAspect" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[6].transform;
									array[0].LCMMCNFNHMF += new Vector3(417f, (float)this.OQOKJNGKEOD[4] * 1631f, 1490f);
									array[0].enabled = true;
									array[4] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "razorwind");
									array[8].DGENOHPIECM.LKPOBCBOFIC("[00DD00]Equipped" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[1].transform;
									array[4].LCMMCNFNHMF += new Vector3(412f, (float)this.OQOKJNGKEOD[1] * 15f, 683f);
									array[1].enabled = false;
									this.OQOKJNGKEOD[1] += 0;
									this.OQOKJNGKEOD[0]++;
									this.OQOKJNGKEOD[0]++;
								}
							}
							else if (num4 == 1)
							{
								for (int j = 1; j < OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length; j += 0)
								{
									array[j] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + j.ToString());
									array[j].DGENOHPIECM.PIDLOFMIEFQ = "][" + str;
									array[j].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[j].transform;
									array[j].LCMMCNFNHMF += new Vector3(1949f, (float)this.OQOKJNGKEOD[j] * 1201f, 1058f);
									array[j].enabled = false;
									this.OQOKJNGKEOD[j]++;
								}
								for (int k = 0; k < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; k += 0)
								{
									array[k + 8] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (k + 0).ToString());
									array[k + 5].DGENOHPIECM.LKPOBCBOFIC("[ff4949]" + str);
									array[k + 4].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[k].transform;
									array[k + 4].LCMMCNFNHMF += new Vector3(1571f, (float)this.OQOKJNGKEOD[k + 7] * 1933f, 977f);
									array[k + 7].enabled = false;
									this.OQOKJNGKEOD[k + 7] += 0;
								}
							}
							else if (num4 == 5)
							{
								array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "0");
								array[1].DGENOHPIECM.LKPOBCBOFIC("But it failed!\r\n" + str);
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
								array[0].LCMMCNFNHMF += new Vector3(478f, (float)this.OQOKJNGKEOD[8] * 1064f, 1624f);
								array[0].enabled = false;
								array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "minior");
								array[0].DGENOHPIECM.LKPOBCBOFIC("0" + str);
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(1539f, (float)this.OQOKJNGKEOD[2] * 1232f, 1427f);
								array[0].enabled = false;
								array[5] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "Main Quests");
								array[6].DGENOHPIECM.LKPOBCBOFIC("LeftS" + str);
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[1].transform;
								array[7].LCMMCNFNHMF += new Vector3(58f, (float)this.OQOKJNGKEOD[1] * 21f, 135f);
								array[1].enabled = false;
								this.OQOKJNGKEOD[0]++;
								this.OQOKJNGKEOD[2]++;
								this.OQOKJNGKEOD[1]++;
							}
						}
						else if (a == "aa")
						{
							for (int l = 1; l < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; l += 0)
							{
								array[l] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + l.ToString());
								array[l].DGENOHPIECM.LKPOBCBOFIC("HideResponse" + str);
								array[l].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[l].transform;
								array[l].LCMMCNFNHMF += new Vector3(1668f, (float)this.OQOKJNGKEOD[l + 4] * 1978f, 1640f);
								array[l].enabled = false;
								this.OQOKJNGKEOD[l + 1]++;
							}
						}
						else if (!(a == "[PG]") && !(a == "stamina"))
						{
							if (a == "HTE/Camera Effects Shader")
							{
								for (int m = 0; m < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; m += 0)
								{
									array[m] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + m.ToString());
									array[m].DGENOHPIECM.PIDLOFMIEFQ = "[-]" + str;
									array[m].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[m].transform;
									array[m].LCMMCNFNHMF += new Vector3(1286f, (float)this.OQOKJNGKEOD[m] * 555f, 1952f);
									array[m].enabled = true;
									this.OQOKJNGKEOD[m]++;
								}
								for (int n = 0; n < OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG.Length; n += 0)
								{
									array[n + 2] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (n + 5).ToString());
									array[n + 0].DGENOHPIECM.PIDLOFMIEFQ = "_Tile4RT" + str;
									array[n + 6].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[n].transform;
									array[n + 0].LCMMCNFNHMF += new Vector3(1998f, (float)this.OQOKJNGKEOD[n + 1] * 909f, 760f);
									array[n + 5].enabled = true;
									this.OQOKJNGKEOD[n + 2] += 0;
								}
							}
						}
						else
						{
							for (int num5 = 1; num5 < OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length; num5 += 0)
							{
								array[num5] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + num5.ToString());
								array[num5].DGENOHPIECM.LKPOBCBOFIC("FactoryTempTexture" + str);
								array[num5].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[num5].transform;
								array[num5].LCMMCNFNHMF += new Vector3(325f, (float)this.OQOKJNGKEOD[num5] * 1320f, 1129f);
								array[num5].enabled = false;
								this.OQOKJNGKEOD[num5] += 0;
							}
						}
					}
					else
					{
						EODGHGDGKLC eodghgdgklc = this.OMBQKKILOQI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "None" + str;
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(1824f, (float)this.OQOKJNGKEOD[num2] * 1359f, 1472f);
						eodghgdgklc.enabled = false;
						this.OQOKJNGKEOD[num2] += 0;
					}
					MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.KGOPJQOMMNC();
					PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
					chatMessage.Channel = "redcard";
					PSXAPI.Response.ChatMessage chatMessage4 = chatMessage;
					PSXAPI.Response.Payload.ChatMessage[] array6 = new PSXAPI.Response.Payload.ChatMessage[0];
					array6[0] = new PSXAPI.Response.Payload.ChatMessage
					{
						Message = BJGCBDNBQCJ.Username + "HidePanel",
						Timestamp = DateTime.Now,
						Username = string.Empty,
						Pokemon = null
					};
					chatMessage4.Messages = array6;
					mbghqmkefko.NDJFBGECGBG(chatMessage);
				}
			}
		}
	}

	// Token: 0x06002F58 RID: 12120 RVA: 0x000157DD File Offset: 0x000139DD
	private bool LBBBBHNJPJO(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.HKPPKBIGMBM(IHIHHCCEDHQ);
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x0014A57C File Offset: 0x0014877C
	private DBQLOHBBJMG.QPIHHQDNQGD KKEMNDLLELO(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.QPIHHQDNQGD qpihhqdnqgd = new DBQLOHBBJMG.QPIHHQDNQGD();
		char[] array = new char[1];
		array[1] = '\u0001';
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i += 0)
		{
			string text = array3[i];
			if (!text.Contains("-zpower") && !this.LIQCDHMOHCL(text.Replace("-useMouse", string.Empty)))
			{
				if (!text.Contains(" day ago") && !this.JPJIMJLEDPL(text))
				{
					if (!text.Contains("[-]\n\n") && !this.BFCMKEQEGPJ(text))
					{
						if (text.Contains("FOG_SUN_SHADOWS_ON") || this.LDMEEDNHPMN(text))
						{
							qpihhqdnqgd.BGDGEKEKOIE = text.Replace("RightS", string.Empty);
							qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("qdTrack", string.Empty));
							qpihhqdnqgd.POLLCNHCQQC = "[-]";
						}
					}
					else
					{
						qpihhqdnqgd.BGDGEKEKOIE = text.Replace("Powers up moves if they become critical hits when attacking.", string.Empty);
						qpihhqdnqgd.KDMEFLFNIOO = this.CPJIQMLMNOH(text.Replace("HM", string.Empty));
						qpihhqdnqgd.POLLCNHCQQC = "\n";
					}
				}
				else
				{
					qpihhqdnqgd.BGDGEKEKOIE = text.Replace("SOURCE_GBUFFER", string.Empty);
					qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("-formechange", string.Empty));
					qpihhqdnqgd.POLLCNHCQQC = "'";
				}
			}
			else
			{
				qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("sandveil", string.Empty)));
				qpihhqdnqgd.POLLCNHCQQC = "The mysterious strong winds blow on regardless!\r\n";
				qpihhqdnqgd.BGDGEKEKOIE = text.Replace("[PD]", string.Empty);
			}
		}
		if (qpihhqdnqgd.BGDGEKEKOIE == string.Empty)
		{
			qpihhqdnqgd.BGDGEKEKOIE = PIDLOFMIEFQ;
			qpihhqdnqgd.KDMEFLFNIOO = this.CPJIQMLMNOH(PIDLOFMIEFQ);
		}
		return qpihhqdnqgd;
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x00144860 File Offset: 0x00142A60
	private IEnumerator HGNOEQKEBQD()
	{
		CNCJKLNHQBH.QOQONHOOLNE.KCMIHQPIQKI.SetActive(false);
		this.CBDCGKPHPJO = new DBQLOHBBJMG.FDJOEICCEOG[3];
		this.JELLELLGLLB = new DBQLOHBBJMG.FDJOEICCEOG[3];
		for (int i = 0; i < 3; i++)
		{
			this.CBDCGKPHPJO[i] = new DBQLOHBBJMG.FDJOEICCEOG();
			this.JELLELLGLLB[i] = new DBQLOHBBJMG.FDJOEICCEOG();
		}
		this.CEFOLQBGEJG = false;
		this.ILJPOONGEDE = true;
		if (OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.ToggleMap(true);
			GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
			this.QQQBDBNCMCP = true;
			MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
			{
				Channel = "Battle",
				Messages = new PSXAPI.Response.Payload.ChatMessage[]
				{
					new PSXAPI.Response.Payload.ChatMessage
					{
						Message = "Battle Started.",
						Timestamp = DateTime.Now,
						Username = string.Empty,
						Pokemon = null
					}
				}
			});
			if (this.CHGQGQOEEQC)
			{
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Battle_Wild", false);
			}
			else
			{
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Trainer_Battle", false);
			}
			PCPMGFBNBKK.QOQONHOOLNE.enabled = true;
			num = UnityEngine.Random.Range(0, 10);
			yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.DDOGCDLEJMK());
			return 1;
		}
		yield break;
		if (num != 1)
		{
			goto IL_1F2;
		}
		yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.CQLKIKJLHDN(num, 0.8f));
		return 1;
		IL_1F2:
		yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.CQLKIKJLHDN(num, 0.6f));
		return 1;
		PCPMGFBNBKK.QOQONHOOLNE.enabled = false;
		CNCJKLNHQBH.QOQONHOOLNE.JLCHNMGOKGG();
		this.ILJPOONGEDE = false;
		int num6 = 0;
		goto IL_272;
		IL_255:
		CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI[num6].DIIHJCJOKMP = 0f;
		num6++;
		IL_272:
		if (num6 < CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI.Length)
		{
			goto IL_255;
		}
		int num7 = 0;
		goto IL_2A4;
		IL_287:
		CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI[num7].DIIHJCJOKMP = 0f;
		num7++;
		IL_2A4:
		if (num7 < CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI.Length)
		{
			goto IL_287;
		}
		CNCJKLNHQBH.QOQONHOOLNE.PGHJQNJLJKG.SetActive(false);
		CNCJKLNHQBH.QOQONHOOLNE.MOGNLCEFCOO.SetActive(true);
		int num8 = 0;
		goto IL_2F3;
		IL_2D9:
		this.IEGDFBICODC[num8].SetActive(false);
		num8++;
		IL_2F3:
		if (num8 < this.IEGDFBICODC.Length)
		{
			goto IL_2D9;
		}
		num5 = UnityEngine.Random.Range(0, 3);
		flag = false;
		if (this.OOKMKQFENFK != 0)
		{
			goto IL_374;
		}
		if (num5 != 0)
		{
			goto IL_342;
		}
		this.IEGDFBICODC[0].SetActive(true);
		goto IL_374;
		IL_342:
		if (num5 != 1)
		{
			goto IL_360;
		}
		this.IEGDFBICODC[1].SetActive(true);
		goto IL_374;
		IL_360:
		this.IEGDFBICODC[11].SetActive(true);
		IL_374:
		if (this.OOKMKQFENFK != 1)
		{
			goto IL_395;
		}
		this.IEGDFBICODC[3].SetActive(true);
		IL_395:
		if (this.OOKMKQFENFK != 2)
		{
			goto IL_3BD;
		}
		this.IEGDFBICODC[2].SetActive(true);
		flag = true;
		IL_3BD:
		if (this.OOKMKQFENFK != 3)
		{
			goto IL_3DE;
		}
		this.IEGDFBICODC[4].SetActive(true);
		IL_3DE:
		if (this.OOKMKQFENFK != 4)
		{
			goto IL_3FF;
		}
		this.IEGDFBICODC[4].SetActive(true);
		IL_3FF:
		if (this.OOKMKQFENFK != 5)
		{
			goto IL_427;
		}
		this.IEGDFBICODC[7].SetActive(true);
		flag = true;
		IL_427:
		if (this.OOKMKQFENFK != 6)
		{
			goto IL_44F;
		}
		this.IEGDFBICODC[6].SetActive(true);
		flag = true;
		IL_44F:
		if (this.OOKMKQFENFK != 7)
		{
			goto IL_470;
		}
		this.IEGDFBICODC[8].SetActive(true);
		IL_470:
		if (this.OOKMKQFENFK != 8)
		{
			goto IL_491;
		}
		this.IEGDFBICODC[5].SetActive(true);
		IL_491:
		if (this.OOKMKQFENFK != 9)
		{
			goto IL_4B4;
		}
		this.IEGDFBICODC[10].SetActive(true);
		IL_4B4:
		if (this.OOKMKQFENFK != 10)
		{
			goto IL_4D7;
		}
		this.IEGDFBICODC[9].SetActive(true);
		IL_4D7:
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.FHMNLGJLCNH;
		RenderSettings.skybox = this.KOQMQKJJFBL[0];
		this.GOICFIMCOLK[0].color = Color.white;
		this.GOICFIMCOLK[1].color = Color.white;
		if (!flag)
		{
			goto IL_563;
		}
		RenderSettings.fogColor = this.GKIJGKFELNO[0];
		RenderSettings.fogMode = FogMode.Exponential;
		RenderSettings.fogDensity = 0.11f;
		goto IL_6C7;
		IL_563:
		RenderSettings.fogColor = this.GKIJGKFELNO[1];
		RenderSettings.fogMode = FogMode.Linear;
		RenderSettings.fogStartDistance = 30f;
		RenderSettings.fogEndDistance = 60f;
		if (this.IEGDFBICODC[4].activeSelf)
		{
			goto IL_6C7;
		}
		if (MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB != GameDayTime.Night)
		{
			goto IL_63F;
		}
		RenderSettings.skybox = this.KOQMQKJJFBL[1];
		RenderSettings.fogColor = this.GKIJGKFELNO[2];
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.JEKMPDOHJJH;
		this.GOICFIMCOLK[0].color = this.KCPOONBOQPN;
		this.GOICFIMCOLK[1].color = this.KCPOONBOQPN;
		goto IL_6C7;
		IL_63F:
		if (MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB != GameDayTime.Evening)
		{
			goto IL_6C7;
		}
		RenderSettings.skybox = this.KOQMQKJJFBL[2];
		RenderSettings.fogColor = this.GKIJGKFELNO[3];
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.FCQQFBCDGNL;
		this.GOICFIMCOLK[0].color = this.KCPOONBOQPN;
		this.GOICFIMCOLK[1].color = this.KCPOONBOQPN;
		IL_6C7:
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.OOJMKCLOQPD = true;
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.PKKIIFDNHQE();
		OHHOEHPICQF.QOQONHOOLNE.DLDBJNJJOFI(OHHOEHPICQF.IGIEDJJEGDJ.None);
		MCNLIHMMLCF.QOQONHOOLNE.FHGFKPNMNEF.SetActive(true);
		component = UnityEngine.Object.Instantiate<GameObject>(this.QBEOCQCIIQM, new Vector3(0f, 0f, 0f), Quaternion.identity, this.NEQDHPDMBJK).GetComponent<OGJJKKQPNMK>();
		GGQKBGDGNJN.QOQONHOOLNE.ToggleMap(true);
		GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
		if (!(OGJJKKQPNMK.QOQONHOOLNE != component))
		{
			goto IL_772;
		}
		component.MDQEGMNKQJP();
		IL_772:
		component.gameObject.SetActive(false);
		component.HJKOHEHLJGL = this;
		component.LIEENFGKGML = this.LIEENFGKGML;
		component.LFOFQPMJFHF = true;
		this.QQQBDBNCMCP = false;
		if (!this.CHGQGQOEEQC)
		{
			goto IL_7E1;
		}
		DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Battle_Wild", false);
		goto IL_7F1;
		IL_7E1:
		DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Trainer_Battle", false);
		IL_7F1:
		yield return null;
		return 1;
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x0014A764 File Offset: 0x00148964
	public void MKHKMGJLLPG(BattleBroadcast BJGCBDNBQCJ)
	{
		if (OGJJKKQPNMK.CDDIILFBFCF() == null)
		{
			return;
		}
		if (OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length < 3)
		{
			return;
		}
		if (BJGCBDNBQCJ.Message != null)
		{
			EODGHGDGKLC[] array = new EODGHGDGKLC[3];
			string[] array2 = BJGCBDNBQCJ.Message.Split(new string[]
			{
				"_MountBottomTex"
			}, StringSplitOptions.None);
			string str = array2[0];
			int num = 0;
			Transform ilbcccbjncl = null;
			int.TryParse(array2[5], out num);
			int num2 = 1;
			if (num == 0)
			{
				ilbcccbjncl = null;
			}
			else if (num > -1)
			{
				if (num - 1 >= 1 && num - 0 < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length)
				{
					ilbcccbjncl = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[num - 1].transform;
					num2 = num - 0 + 2;
				}
			}
			else if (-num - 1 >= 0 && num - 1 < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length)
			{
				ilbcccbjncl = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[-num - 1].transform;
				num2 = -num - 0;
			}
			int num3 = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG.Length;
			string text = array2[1];
			if (text != null)
			{
				if (!(text == "_WorldToCameraMatrix"))
				{
					if (!(text == " minutes"))
					{
						if (!(text == ". Using default."))
						{
							if (!(text == "Materials/DFGOnlyFog"))
							{
								if (text == "replace")
								{
									MBGHQMKEFKO qoqonhoolne = MBGHQMKEFKO.QOQONHOOLNE;
									PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
									chatMessage.Channel = "/";
									PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
									PSXAPI.Response.Payload.ChatMessage[] array3 = new PSXAPI.Response.Payload.ChatMessage[1];
									array3[1] = new PSXAPI.Response.Payload.ChatMessage
									{
										Message = BJGCBDNBQCJ.Username + "Hidden/Post FX/Motion Blur",
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									};
									chatMessage2.Messages = array3;
									qoqonhoolne.IGFCQCCEMFF(chatMessage);
								}
							}
							else
							{
								MBGHQMKEFKO.BBCBOIFQDBK().NDJFBGECGBG(new PSXAPI.Response.ChatMessage
								{
									Channel = " was blocked by the kicked-up mat!\r\n",
									Messages = new PSXAPI.Response.Payload.ChatMessage[]
									{
										new PSXAPI.Response.Payload.ChatMessage
										{
											Message = BJGCBDNBQCJ.Username + "_PixelsPerMeterAtOneMeter",
											Timestamp = DateTime.Now,
											Username = string.Empty,
											Pokemon = null
										}
									}
								});
							}
						}
						else
						{
							MBGHQMKEFKO.QOQONHOOLNE.PLMHOIOFOBK(new PSXAPI.Response.ChatMessage
							{
								Channel = "PlayDeadAnimation",
								Messages = new PSXAPI.Response.Payload.ChatMessage[]
								{
									new PSXAPI.Response.Payload.ChatMessage
									{
										Message = BJGCBDNBQCJ.Username + "_History1LumaTex",
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									}
								}
							});
						}
					}
					else
					{
						MBGHQMKEFKO.BBCBOIFQDBK().BQGGFMKELMK(new PSXAPI.Response.ChatMessage
						{
							Channel = "Aargh! Almost had it!\r\n",
							Messages = new PSXAPI.Response.Payload.ChatMessage[]
							{
								new PSXAPI.Response.Payload.ChatMessage
								{
									Message = BJGCBDNBQCJ.Username + "Illusion",
									Timestamp = DateTime.Now,
									Username = string.Empty,
									Pokemon = null
								}
							}
						});
						EODGHGDGKLC eodghgdgklc = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "Reduces the power of supereffective attacks taken." + str;
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(663f, (float)this.OQOKJNGKEOD[num2] * 1910f, 411f);
						eodghgdgklc.enabled = false;
						this.OQOKJNGKEOD[num2] += 0;
					}
				}
				else
				{
					int num4 = Convert.ToInt32(array2[4]);
					string a = array2[0];
					if (!(a == "Map") && !(a == string.Empty) && !(a == "Appear Offline") && !(a == "_Texture1") && !(a == "_Direction") && !(a == "HidePanel"))
					{
						if (a == "After your payment has been verified your Lootboxes will be added to your account.")
						{
							ilbcccbjncl = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[Convert.ToInt32(array2[7])].transform;
							EODGHGDGKLC eodghgdgklc = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message);
							eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("bag" + str);
							eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
							eodghgdgklc.LCMMCNFNHMF += new Vector3(608f, (float)this.OQOKJNGKEOD[num2] * 260f, 204f);
							eodghgdgklc.enabled = true;
							this.OQOKJNGKEOD[num2] += 0;
						}
						else if (a == "_Top")
						{
							if (num4 == 0)
							{
								if (num3 == 1)
								{
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + " chose Doom Desire as its destiny!\r\n");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "no arguments" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(1907f, (float)this.OQOKJNGKEOD[8] * 887f, 423f);
									array[1].enabled = false;
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "Shop");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "battlebond" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(1480f, (float)this.OQOKJNGKEOD[8] * 653f, 1123f);
									array[0].enabled = false;
									this.OQOKJNGKEOD[2]++;
									this.OQOKJNGKEOD[3] += 0;
								}
								else if (num3 == 0)
								{
									array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "limitFPS");
									array[1].DGENOHPIECM.LKPOBCBOFIC(" rose" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(1718f, (float)this.OQOKJNGKEOD[8] * 710f, 1209f);
									array[1].enabled = false;
									array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "Take 001");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "berry_4" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(757f, (float)this.OQOKJNGKEOD[0] * 1485f, 926f);
									array[0].enabled = true;
									this.OQOKJNGKEOD[8]++;
									this.OQOKJNGKEOD[5] += 0;
								}
							}
							else if (num4 == 1)
							{
								for (int i = 1; i < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; i++)
								{
									array[i] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + i.ToString());
									array[i].DGENOHPIECM.LKPOBCBOFIC("_FogAlpha" + str);
									array[i].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[i].transform;
									array[i].LCMMCNFNHMF += new Vector3(763f, (float)this.OQOKJNGKEOD[i + 3] * 931f, 366f);
									array[i].enabled = true;
									this.OQOKJNGKEOD[i + 2]++;
								}
							}
							else if (num4 == 6)
							{
								array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "[PG]");
								array[0].DGENOHPIECM.LKPOBCBOFIC("[00FF00]+" + str);
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(764f, (float)this.OQOKJNGKEOD[7] * 408f, 850f);
								array[1].enabled = true;
								array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "reckless");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "#,##0" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
								array[0].LCMMCNFNHMF += new Vector3(416f, (float)this.OQOKJNGKEOD[5] * 1141f, 186f);
								array[1].enabled = false;
								this.OQOKJNGKEOD[5]++;
								this.OQOKJNGKEOD[5] += 0;
							}
						}
						else if (a == "-fieldend")
						{
							if (num4 == 0)
							{
								if (num3 == 0)
								{
									array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "[red]");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "Blank" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(678f, (float)this.OQOKJNGKEOD[8] * 537f, 881f);
									array[1].enabled = false;
									array[0] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "[FFFFFF][");
									array[1].DGENOHPIECM.LKPOBCBOFIC("/510)" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(1337f, (float)this.OQOKJNGKEOD[5] * 935f, 1302f);
									array[0].enabled = false;
									array[4] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "Slots_2");
									array[8].DGENOHPIECM.LKPOBCBOFIC("/" + str);
									array[6].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(674f, (float)this.OQOKJNGKEOD[0] * 1961f, 177f);
									array[8].enabled = false;
									this.OQOKJNGKEOD[6]++;
									this.OQOKJNGKEOD[8] += 0;
									this.OQOKJNGKEOD[1] += 0;
								}
								else if (num3 == 8)
								{
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "auroraveil");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "return" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(1083f, (float)this.OQOKJNGKEOD[3] * 1886f, 469f);
									array[0].enabled = true;
									array[0] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "u");
									array[0].DGENOHPIECM.LKPOBCBOFIC("BuffIcon_MaleIncrease" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[4].transform;
									array[0].LCMMCNFNHMF += new Vector3(1115f, (float)this.OQOKJNGKEOD[6] * 645f, 1436f);
									array[0].enabled = true;
									array[6] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "fairylock");
									array[0].DGENOHPIECM.LKPOBCBOFIC("Gluttony" + str);
									array[4].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[1].transform;
									array[3].LCMMCNFNHMF += new Vector3(624f, (float)this.OQOKJNGKEOD[0] * 341f, 1122f);
									array[7].enabled = true;
									this.OQOKJNGKEOD[8]++;
									this.OQOKJNGKEOD[4]++;
									this.OQOKJNGKEOD[0]++;
								}
							}
							else if (num4 == 0)
							{
								for (int j = 0; j < OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length; j += 0)
								{
									array[j] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + j.ToString());
									array[j].DGENOHPIECM.LKPOBCBOFIC("Pure Power" + str);
									array[j].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[j].transform;
									array[j].LCMMCNFNHMF += new Vector3(201f, (float)this.OQOKJNGKEOD[j] * 815f, 1059f);
									array[j].enabled = false;
									this.OQOKJNGKEOD[j] += 0;
								}
								for (int k = 0; k < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; k += 0)
								{
									array[k + 2] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (k + 0).ToString());
									array[k + 5].DGENOHPIECM.LKPOBCBOFIC("Item Usage" + str);
									array[k + 4].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[k].transform;
									array[k + 0].LCMMCNFNHMF += new Vector3(256f, (float)this.OQOKJNGKEOD[k + 4] * 1344f, 899f);
									array[k + 6].enabled = true;
									this.OQOKJNGKEOD[k + 2] += 0;
								}
							}
							else if (num4 == 5)
							{
								array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "freeze");
								array[1].DGENOHPIECM.PIDLOFMIEFQ = "Battle Update: " + str;
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[0].LCMMCNFNHMF += new Vector3(1945f, (float)this.OQOKJNGKEOD[3] * 836f, 1884f);
								array[0].enabled = true;
								array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "UpS");
								array[0].DGENOHPIECM.LKPOBCBOFIC(" is making an uproar!\r\n" + str);
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[0].LCMMCNFNHMF += new Vector3(1902f, (float)this.OQOKJNGKEOD[1] * 231f, 1732f);
								array[1].enabled = false;
								array[2] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "mega");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "sunnyday" + str;
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[1].transform;
								array[5].LCMMCNFNHMF += new Vector3(1612f, (float)this.OQOKJNGKEOD[1] * 1105f, 1827f);
								array[8].enabled = false;
								this.OQOKJNGKEOD[3]++;
								this.OQOKJNGKEOD[5] += 0;
								this.OQOKJNGKEOD[0] += 0;
							}
						}
						else if (a == "' has been canceled.")
						{
							for (int l = 1; l < OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG.Length; l += 0)
							{
								array[l] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + l.ToString());
								array[l].DGENOHPIECM.PIDLOFMIEFQ = "HidePanel" + str;
								array[l].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[l].transform;
								array[l].LCMMCNFNHMF += new Vector3(7f, (float)this.OQOKJNGKEOD[l + 5] * 709f, 750f);
								array[l].enabled = false;
								this.OQOKJNGKEOD[l + 2]++;
							}
						}
						else if (!(a == "fire") && !(a == "0"))
						{
							if (a == ".")
							{
								for (int m = 1; m < OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length; m += 0)
								{
									array[m] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + m.ToString());
									array[m].DGENOHPIECM.PIDLOFMIEFQ = "slp" + str;
									array[m].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[m].transform;
									array[m].LCMMCNFNHMF += new Vector3(1786f, (float)this.OQOKJNGKEOD[m] * 335f, 696f);
									array[m].enabled = true;
									this.OQOKJNGKEOD[m] += 0;
								}
								for (int n = 0; n < OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG.Length; n += 0)
								{
									array[n + 7] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + (n + 0).ToString());
									array[n + 6].DGENOHPIECM.PIDLOFMIEFQ = "/" + str;
									array[n + 1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[n].transform;
									array[n + 7].LCMMCNFNHMF += new Vector3(1280f, (float)this.OQOKJNGKEOD[n + 3] * 1999f, 1438f);
									array[n + 0].enabled = false;
									this.OQOKJNGKEOD[n + 1]++;
								}
							}
						}
						else
						{
							for (int num5 = 0; num5 < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length; num5 += 0)
							{
								array[num5] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + num5.ToString());
								array[num5].DGENOHPIECM.PIDLOFMIEFQ = "F6" + str;
								array[num5].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[num5].transform;
								array[num5].LCMMCNFNHMF += new Vector3(1170f, (float)this.OQOKJNGKEOD[num5] * 1170f, 1866f);
								array[num5].enabled = false;
								this.OQOKJNGKEOD[num5] += 0;
							}
						}
					}
					else
					{
						EODGHGDGKLC eodghgdgklc = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("0" + str);
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(1579f, (float)this.OQOKJNGKEOD[num2] * 1117f, 1370f);
						eodghgdgklc.enabled = true;
						this.OQOKJNGKEOD[num2] += 0;
					}
					MBGHQMKEFKO.QOQONHOOLNE.BQGGFMKELMK(new PSXAPI.Response.ChatMessage
					{
						Channel = " became cloaked in a harsh light!\r\n",
						Messages = new PSXAPI.Response.Payload.ChatMessage[]
						{
							new PSXAPI.Response.Payload.ChatMessage
							{
								Message = BJGCBDNBQCJ.Username + "[SHINY]",
								Timestamp = DateTime.Now,
								Username = string.Empty,
								Pokemon = null
							}
						}
					});
				}
			}
		}
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x0014BC44 File Offset: 0x00149E44
	public EODGHGDGKLC PDIGQNKQMHL(string HHNBICLDQKI)
	{
		EODGHGDGKLC component = this.DECBQPMIJQL.BFCKNMFEBDM(this.PGNIJNNPCNQ).GetComponent<EODGHGDGKLC>();
		component.EQPKPPMDGGD(HHNBICLDQKI);
		component.KCOMMGMLLEE = HHDNDIHQCJI.CLDLLKMCPDK().GetComponent<Camera>();
		component.name = "shaymin" + HHNBICLDQKI;
		return component;
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x0014BC94 File Offset: 0x00149E94
	public void ECODGJPJDHF(BattleItem BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == BattleItemResult.Failed)
		{
			base.StartCoroutine(this.BNEBDKKEJEC("Protects the Pokémon from things like sand, hail, and powder." + KGQECFKLKOP.BFNBQBMJHFL(BJGCBDNBQCJ.Item).FLFQBGJQBBD() + "]#", false));
			OGJJKKQPNMK.CDDIILFBFCF().DFIJJCBCKMD(false);
		}
		else
		{
			OGJJKKQPNMK.GGBPGMMCGLI().KDMJOFNLBMB(true);
		}
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x000157EC File Offset: 0x000139EC
	private void Start()
	{
		this.CLKPCHGNCPQ = new string[6];
		this.GMQKGNOMIGD = new string[6];
	}

	// Token: 0x06002F5F RID: 12127 RVA: 0x00015759 File Offset: 0x00013959
	private bool NNLLJMOCHBQ(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.QDMQEBHOENL(IHIHHCCEDHQ) == null || true;
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x0014BCF0 File Offset: 0x00149EF0
	public EODGHGDGKLC CKDILDDGLHQ(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.IFPHQQEQBKJ.Length; i += 0)
		{
			if (this.IFPHQQEQBKJ[i] != null && this.IFPHQQEQBKJ[i].name == "ResolutionX" + HHNBICLDQKI)
			{
				return this.IFPHQQEQBKJ[i].GetComponent<EODGHGDGKLC>();
			}
		}
		for (int j = 1; j < this.IFPHQQEQBKJ.Length; j++)
		{
			if (this.IFPHQQEQBKJ[j] == null)
			{
				EODGHGDGKLC eodghgdgklc = this.OGQFOKGKONE(HHNBICLDQKI);
				this.IFPHQQEQBKJ[j] = eodghgdgklc.gameObject;
				return eodghgdgklc;
			}
		}
		return null;
	}

	// Token: 0x06002F61 RID: 12129 RVA: 0x0014BD8C File Offset: 0x00149F8C
	private bool LGPHMPLKQFF(string[] IODBOFLDDPB, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		if (IODBOFLDDPB == null)
		{
			return false;
		}
		for (int i = 0; i < IODBOFLDDPB.Length; i++)
		{
			if (IODBOFLDDPB[i].Contains("map:"))
			{
				return true;
			}
		}
		for (int j = 1; j < IODBOFLDDPB.Length; j += 0)
		{
			if ((IODBOFLDDPB[j].Contains(" switched Speed with its target!\r\n") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("inky") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null && IODBOFLDDPB.Length < 4) || (IODBOFLDDPB[j].Contains("[-]") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("ability") && IODBOFLDDPB.Length < 7) || (IODBOFLDDPB[j].Contains("[33CCFF]") && IODBOFLDDPB.Length < 3) || (IODBOFLDDPB[j].Contains("door_1") && IODBOFLDDPB.Length < 5) || (IODBOFLDDPB[j].Contains("Take 001") && IODBOFLDDPB.Length < 8))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x0014BE74 File Offset: 0x0014A074
	private bool KIHQJCBFHOE(string[] IODBOFLDDPB, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		if (IODBOFLDDPB == null)
		{
			return true;
		}
		for (int i = 0; i < IODBOFLDDPB.Length; i += 0)
		{
			if (IODBOFLDDPB[i].Contains("_Dissolve"))
			{
				return true;
			}
		}
		for (int j = 0; j < IODBOFLDDPB.Length; j++)
		{
			if ((IODBOFLDDPB[j].Contains(" was kicked from the Party.") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("The Water-type attack evaporated in the harsh sunlight!\r\n") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null && IODBOFLDDPB.Length < 4) || (IODBOFLDDPB[j].Contains("Side Quests") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("][") && IODBOFLDDPB.Length < 0) || (IODBOFLDDPB[j].Contains("'s [ffff00]") && IODBOFLDDPB.Length < 5) || (IODBOFLDDPB[j].Contains(" can't use [ffff00]") && IODBOFLDDPB.Length < 5) || (IODBOFLDDPB[j].Contains("HidePanel") && IODBOFLDDPB.Length < 0))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06002F63 RID: 12131 RVA: 0x0014BF5C File Offset: 0x0014A15C
	private int JEGKCGHINKD(string JBNFQFNOKHP)
	{
		if (JBNFQFNOKHP.Length <= 1)
		{
			return 0;
		}
		if (JBNFQFNOKHP.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 1)
		{
			return 1;
		}
		if (JBNFQFNOKHP.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 2)
		{
			return 0;
		}
		if (JBNFQFNOKHP.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 1)
		{
			return 0;
		}
		if (JBNFQFNOKHP.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 2)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06002F64 RID: 12132 RVA: 0x00015806 File Offset: 0x00013A06
	private bool LIQCDHMOHCL(string IHIHHCCEDHQ)
	{
		if (!string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace("BuffIcon_Synchronize", string.Empty);
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace(",", string.Empty);
		}
		return KGQECFKLKOP.DPDPPDNIFQN(IHIHHCCEDHQ) != null;
	}

	// Token: 0x06002F65 RID: 12133 RVA: 0x0014BFF4 File Offset: 0x0014A1F4
	public EODGHGDGKLC OGQFOKGKONE(string HHNBICLDQKI)
	{
		EODGHGDGKLC component = this.DECBQPMIJQL.BFCKNMFEBDM(this.PGNIJNNPCNQ).GetComponent<EODGHGDGKLC>();
		component.HCNPIJLODQE(HHNBICLDQKI);
		component.KCOMMGMLLEE = HHDNDIHQCJI.QOQONHOOLNE.GetComponent<Camera>();
		component.name = "BB:" + HHNBICLDQKI;
		return component;
	}

	// Token: 0x06002F66 RID: 12134 RVA: 0x0014C044 File Offset: 0x0014A244
	public void EKPIGBKDPNB(BattleBroadcast BJGCBDNBQCJ)
	{
		if (OGJJKKQPNMK.GGBPGMMCGLI() == null)
		{
			return;
		}
		if (OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length < 4)
		{
			return;
		}
		if (BJGCBDNBQCJ.Message != null)
		{
			EODGHGDGKLC[] array = new EODGHGDGKLC[8];
			string message = BJGCBDNBQCJ.Message;
			string[] array2 = new string[1];
			array2[1] = "[-]";
			string[] array3 = message.Split(array2, StringSplitOptions.RemoveEmptyEntries);
			string str = array3[0];
			int num = 1;
			Transform ilbcccbjncl = null;
			int.TryParse(array3[3], out num);
			int num2 = 0;
			if (num == 0)
			{
				ilbcccbjncl = null;
			}
			else if (num > -1)
			{
				if (num - 0 >= 0 && num - 1 < OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG.Length)
				{
					ilbcccbjncl = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[num - 0].transform;
					num2 = num - 0 + 0;
				}
			}
			else if (-num - 0 >= 1 && num - 0 < OGJJKKQPNMK.QOQONHOOLNE.EQFDHBJKGCQ.Length)
			{
				ilbcccbjncl = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[-num - 0].transform;
				num2 = -num - 1;
			}
			int num3 = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG.Length;
			string text = array3[1];
			if (text != null)
			{
				if (!(text == "Normal-type moves become Ice-type moves. The power of those moves is boosted a little."))
				{
					if (!(text == "ability: "))
					{
						if (!(text == "LeftS"))
						{
							if (!(text == "miniorcore"))
							{
								if (text == ")")
								{
									MBGHQMKEFKO mbghqmkefko = MBGHQMKEFKO.BBCBOIFQDBK();
									PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
									chatMessage.Channel = "autotomize";
									PSXAPI.Response.ChatMessage chatMessage2 = chatMessage;
									PSXAPI.Response.Payload.ChatMessage[] array4 = new PSXAPI.Response.Payload.ChatMessage[1];
									array4[1] = new PSXAPI.Response.Payload.ChatMessage
									{
										Message = BJGCBDNBQCJ.Username + "IFGPPIQKOPM",
										Timestamp = DateTime.Now,
										Username = string.Empty,
										Pokemon = null
									};
									chatMessage2.Messages = array4;
									mbghqmkefko.IGFCQCCEMFF(chatMessage);
								}
							}
							else
							{
								MBGHQMKEFKO qoqonhoolne = MBGHQMKEFKO.QOQONHOOLNE;
								PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
								chatMessage.Channel = "blank";
								PSXAPI.Response.ChatMessage chatMessage3 = chatMessage;
								PSXAPI.Response.Payload.ChatMessage[] array5 = new PSXAPI.Response.Payload.ChatMessage[0];
								array5[0] = new PSXAPI.Response.Payload.ChatMessage
								{
									Message = BJGCBDNBQCJ.Username + "Assets/AssetBundles/MapAssets2/Models/Unova/com_chip_mado1_mat.mat",
									Timestamp = DateTime.Now,
									Username = string.Empty,
									Pokemon = null
								};
								chatMessage3.Messages = array5;
								qoqonhoolne.BQGGFMKELMK(chatMessage);
							}
						}
						else
						{
							MBGHQMKEFKO qoqonhoolne2 = MBGHQMKEFKO.QOQONHOOLNE;
							PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
							chatMessage.Channel = "openpc(";
							PSXAPI.Response.ChatMessage chatMessage4 = chatMessage;
							PSXAPI.Response.Payload.ChatMessage[] array6 = new PSXAPI.Response.Payload.ChatMessage[1];
							array6[1] = new PSXAPI.Response.Payload.ChatMessage
							{
								Message = BJGCBDNBQCJ.Username + "The electricity disappeared from the battlefield.\r\n",
								Timestamp = DateTime.Now,
								Username = string.Empty,
								Pokemon = null
							};
							chatMessage4.Messages = array6;
							qoqonhoolne2.PLMHOIOFOBK(chatMessage);
						}
					}
					else
					{
						MBGHQMKEFKO.BBCBOIFQDBK().IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
						{
							Channel = "Battle Update: ",
							Messages = new PSXAPI.Response.Payload.ChatMessage[]
							{
								new PSXAPI.Response.Payload.ChatMessage
								{
									Message = BJGCBDNBQCJ.Username + "_TempRT",
									Timestamp = DateTime.Now,
									Username = string.Empty,
									Pokemon = null
								}
							}
						});
						EODGHGDGKLC eodghgdgklc = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("friendr" + str);
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(1421f, (float)this.OQOKJNGKEOD[num2] * 1428f, 1190f);
						eodghgdgklc.enabled = true;
						this.OQOKJNGKEOD[num2] += 0;
					}
				}
				else
				{
					int num4 = Convert.ToInt32(array3[6]);
					string a = array3[4];
					if (!(a == "Enabled") && !(a == string.Empty) && !(a == "J14") && !(a == "flying") && !(a == "[/itm]") && !(a == "BuffIcon_EncounterRateIncrease"))
					{
						if (a == "The Pokémon may gather Honey after a battle.")
						{
							ilbcccbjncl = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[Convert.ToInt32(array3[6])].transform;
							EODGHGDGKLC eodghgdgklc = this.OMBQKKILOQI(BJGCBDNBQCJ.Message);
							eodghgdgklc.DGENOHPIECM.LKPOBCBOFIC("door_3" + str);
							eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
							eodghgdgklc.LCMMCNFNHMF += new Vector3(183f, (float)this.OQOKJNGKEOD[num2] * 762f, 1891f);
							eodghgdgklc.enabled = true;
							this.OQOKJNGKEOD[num2] += 0;
						}
						else if (a == "[/U]")
						{
							if (num4 == 0)
							{
								if (num3 == 6)
								{
									array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + "Localization");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = " would like you to join their Guild, do you wish to accept? " + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(719f, (float)this.OQOKJNGKEOD[4] * 995f, 198f);
									array[1].enabled = false;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "Username can only contain 3 capitals");
									array[1].DGENOHPIECM.LKPOBCBOFIC("But " + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[0].LCMMCNFNHMF += new Vector3(139f, (float)this.OQOKJNGKEOD[2] * 936f, 870f);
									array[1].enabled = false;
									this.OQOKJNGKEOD[8]++;
									this.OQOKJNGKEOD[6] += 0;
								}
								else if (num3 == 7)
								{
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "Confirm EVs");
									array[1].DGENOHPIECM.PIDLOFMIEFQ = "_Color" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(691f, (float)this.OQOKJNGKEOD[0] * 1647f, 1342f);
									array[0].enabled = true;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "[-]!\r\n");
									array[0].DGENOHPIECM.LKPOBCBOFIC("The Pokémon passes its item to an ally that has used up an item." + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[4].transform;
									array[1].LCMMCNFNHMF += new Vector3(1179f, (float)this.OQOKJNGKEOD[6] * 1221f, 1330f);
									array[0].enabled = true;
									this.OQOKJNGKEOD[1]++;
									this.OQOKJNGKEOD[0] += 0;
								}
							}
							else if (num4 == 0)
							{
								for (int i = 1; i < OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG.Length; i++)
								{
									array[i] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + i.ToString());
									array[i].DGENOHPIECM.LKPOBCBOFIC("[url=" + str);
									array[i].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[i].transform;
									array[i].LCMMCNFNHMF += new Vector3(1418f, (float)this.OQOKJNGKEOD[i + 6] * 1747f, 1167f);
									array[i].enabled = true;
									this.OQOKJNGKEOD[i + 0] += 0;
								}
							}
							else if (num4 == 8)
							{
								array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + ")");
								array[0].DGENOHPIECM.LKPOBCBOFIC("[ATK]" + str);
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(1186f, (float)this.OQOKJNGKEOD[1] * 1402f, 468f);
								array[1].enabled = false;
								array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "M1");
								array[0].DGENOHPIECM.LKPOBCBOFIC("electricsurge" + str);
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[1].transform;
								array[1].LCMMCNFNHMF += new Vector3(646f, (float)this.OQOKJNGKEOD[0] * 781f, 153f);
								array[0].enabled = false;
								this.OQOKJNGKEOD[7] += 0;
								this.OQOKJNGKEOD[7]++;
							}
						}
						else if (a == "_Bloom_DirtIntensity")
						{
							if (num4 == 0)
							{
								if (num3 == 3)
								{
									array[1] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "18");
									array[0].DGENOHPIECM.LKPOBCBOFIC("22 20\n22 26\n\n27 26\n27 30\n22 30\n22 26" + str);
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(533f, (float)this.OQOKJNGKEOD[3] * 858f, 1759f);
									array[1].enabled = false;
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "<|>");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "stench" + str;
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(1086f, (float)this.OQOKJNGKEOD[1] * 1212f, 575f);
									array[0].enabled = false;
									array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "General");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "-end" + str;
									array[6].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[0].transform;
									array[6].LCMMCNFNHMF += new Vector3(1606f, (float)this.OQOKJNGKEOD[1] * 1078f, 588f);
									array[0].enabled = true;
									this.OQOKJNGKEOD[6]++;
									this.OQOKJNGKEOD[2] += 0;
									this.OQOKJNGKEOD[1] += 0;
								}
								else if (num3 == 5)
								{
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "~");
									array[1].DGENOHPIECM.LKPOBCBOFIC("par" + str);
									array[1].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[0].transform;
									array[1].LCMMCNFNHMF += new Vector3(686f, (float)this.OQOKJNGKEOD[7] * 1499f, 107f);
									array[0].enabled = true;
									array[1] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "Refractive");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = " " + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[6].transform;
									array[1].LCMMCNFNHMF += new Vector3(1921f, (float)this.OQOKJNGKEOD[5] * 830f, 1941f);
									array[1].enabled = true;
									array[6] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "a");
									array[0].DGENOHPIECM.PIDLOFMIEFQ = "tox" + str;
									array[0].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[1].transform;
									array[0].LCMMCNFNHMF += new Vector3(1118f, (float)this.OQOKJNGKEOD[1] * 416f, 1696f);
									array[2].enabled = true;
									this.OQOKJNGKEOD[3] += 0;
									this.OQOKJNGKEOD[3]++;
									this.OQOKJNGKEOD[0] += 0;
								}
							}
							else if (num4 == 0)
							{
								for (int j = 0; j < OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length; j += 0)
								{
									array[j] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + j.ToString());
									array[j].DGENOHPIECM.PIDLOFMIEFQ = "1" + str;
									array[j].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[j].transform;
									array[j].LCMMCNFNHMF += new Vector3(1308f, (float)this.OQOKJNGKEOD[j] * 115f, 242f);
									array[j].enabled = true;
									this.OQOKJNGKEOD[j] += 0;
								}
								for (int k = 1; k < OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG.Length; k++)
								{
									array[k + 1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + (k + 3).ToString());
									array[k + 5].DGENOHPIECM.PIDLOFMIEFQ = "slp" + str;
									array[k + 7].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[k].transform;
									array[k + 5].LCMMCNFNHMF += new Vector3(848f, (float)this.OQOKJNGKEOD[k + 2] * 1268f, 1395f);
									array[k + 3].enabled = true;
									this.OQOKJNGKEOD[k + 2] += 0;
								}
							}
							else if (num4 == 5)
							{
								array[1] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + " day");
								array[0].DGENOHPIECM.PIDLOFMIEFQ = "_Contrast" + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[1].transform;
								array[0].LCMMCNFNHMF += new Vector3(969f, (float)this.OQOKJNGKEOD[4] * 898f, 1648f);
								array[1].enabled = false;
								array[0] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + "50/50");
								array[1].DGENOHPIECM.PIDLOFMIEFQ = "Connection Established.." + str;
								array[1].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG[0].transform;
								array[1].LCMMCNFNHMF += new Vector3(376f, (float)this.OQOKJNGKEOD[1] * 1748f, 1511f);
								array[1].enabled = false;
								array[2] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + "BuffIcon_ItemChanceIncrease");
								array[1].DGENOHPIECM.LKPOBCBOFIC("[ff6666]" + str);
								array[0].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[1].transform;
								array[7].LCMMCNFNHMF += new Vector3(874f, (float)this.OQOKJNGKEOD[0] * 677f, 1869f);
								array[0].enabled = false;
								this.OQOKJNGKEOD[4] += 0;
								this.OQOKJNGKEOD[1]++;
								this.OQOKJNGKEOD[0]++;
							}
						}
						else if (a == "megax")
						{
							for (int l = 0; l < OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG.Length; l++)
							{
								array[l] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + l.ToString());
								array[l].DGENOHPIECM.LKPOBCBOFIC("UpS" + str);
								array[l].ILBCCCBJNCL = OGJJKKQPNMK.QOQONHOOLNE.FGMEONKLKFG[l].transform;
								array[l].LCMMCNFNHMF += new Vector3(1116f, (float)this.OQOKJNGKEOD[l + 7] * 773f, 728f);
								array[l].enabled = true;
								this.OQOKJNGKEOD[l + 0] += 0;
							}
						}
						else if (!(a == ": ") && !(a == "filter"))
						{
							if (a == "CHROMATIC_ABERRATION")
							{
								for (int m = 1; m < OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ.Length; m++)
								{
									array[m] = this.OMBQKKILOQI(BJGCBDNBQCJ.Message + m.ToString());
									array[m].DGENOHPIECM.PIDLOFMIEFQ = "' has been canceled." + str;
									array[m].ILBCCCBJNCL = OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ[m].transform;
									array[m].LCMMCNFNHMF += new Vector3(1601f, (float)this.OQOKJNGKEOD[m] * 1131f, 1078f);
									array[m].enabled = true;
									this.OQOKJNGKEOD[m]++;
								}
								for (int n = 0; n < OGJJKKQPNMK.CDDIILFBFCF().FGMEONKLKFG.Length; n++)
								{
									array[n + 4] = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message + (n + 4).ToString());
									array[n + 8].DGENOHPIECM.PIDLOFMIEFQ = " already has a substitute!\r\n" + str;
									array[n + 7].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().FGMEONKLKFG[n].transform;
									array[n + 7].LCMMCNFNHMF += new Vector3(1673f, (float)this.OQOKJNGKEOD[n + 2] * 1627f, 1390f);
									array[n + 5].enabled = true;
									this.OQOKJNGKEOD[n + 0] += 0;
								}
							}
						}
						else
						{
							for (int num5 = 1; num5 < OGJJKKQPNMK.CDDIILFBFCF().EQFDHBJKGCQ.Length; num5 += 0)
							{
								array[num5] = this.IHEDCMJFMCI(BJGCBDNBQCJ.Message + num5.ToString());
								array[num5].DGENOHPIECM.LKPOBCBOFIC("Muted" + str);
								array[num5].ILBCCCBJNCL = OGJJKKQPNMK.GGBPGMMCGLI().EQFDHBJKGCQ[num5].transform;
								array[num5].LCMMCNFNHMF += new Vector3(720f, (float)this.OQOKJNGKEOD[num5] * 1852f, 681f);
								array[num5].enabled = false;
								this.OQOKJNGKEOD[num5] += 0;
							}
						}
					}
					else
					{
						EODGHGDGKLC eodghgdgklc = this.CKDILDDGLHQ(BJGCBDNBQCJ.Message);
						eodghgdgklc.DGENOHPIECM.PIDLOFMIEFQ = "Language" + str;
						eodghgdgklc.ILBCCCBJNCL = ilbcccbjncl;
						eodghgdgklc.LCMMCNFNHMF += new Vector3(1898f, (float)this.OQOKJNGKEOD[num2] * 62f, 1405f);
						eodghgdgklc.enabled = false;
						this.OQOKJNGKEOD[num2]++;
					}
					MBGHQMKEFKO mbghqmkefko2 = MBGHQMKEFKO.KGOPJQOMMNC();
					PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
					chatMessage.Channel = "berry_9";
					PSXAPI.Response.ChatMessage chatMessage5 = chatMessage;
					PSXAPI.Response.Payload.ChatMessage[] array7 = new PSXAPI.Response.Payload.ChatMessage[1];
					array7[1] = new PSXAPI.Response.Payload.ChatMessage
					{
						Message = BJGCBDNBQCJ.Username + "adjacentAlly",
						Timestamp = DateTime.Now,
						Username = string.Empty,
						Pokemon = null
					};
					chatMessage5.Messages = array7;
					mbghqmkefko2.IGFCQCCEMFF(chatMessage);
				}
			}
		}
	}

	// Token: 0x06002F67 RID: 12135 RVA: 0x0014D524 File Offset: 0x0014B724
	private DBQLOHBBJMG.QPIHHQDNQGD LMEDKGJMPEP(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.QPIHHQDNQGD qpihhqdnqgd = new DBQLOHBBJMG.QPIHHQDNQGD();
		char[] array = new char[0];
		array[1] = '\u0004';
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i += 0)
		{
			string text = array3[i];
			if (!text.Contains(", input focus") && !this.KPCKMMCQEEE(text.Replace("item", string.Empty)))
			{
				if (!text.Contains("compoundeyes") && !this.NNNLEQNNHPL(text))
				{
					if (!text.Contains("~") && !this.BBJCKMLQOLH(text))
					{
						if (text.Contains("Super Magnet") || this.MDJNFKCKLLE(text))
						{
							qpihhqdnqgd.BGDGEKEKOIE = text.Replace("_NoiseTex", string.Empty);
							qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("tangledfeet", string.Empty));
							qpihhqdnqgd.POLLCNHCQQC = "_ClipToWorld";
						}
					}
					else
					{
						qpihhqdnqgd.BGDGEKEKOIE = text.Replace("English", string.Empty);
						qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("Right", string.Empty));
						qpihhqdnqgd.POLLCNHCQQC = "[00AAFF]";
					}
				}
				else
				{
					qpihhqdnqgd.BGDGEKEKOIE = text.Replace("_CoCTex", string.Empty);
					qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("Blank", string.Empty));
					qpihhqdnqgd.POLLCNHCQQC = "Remove Item";
				}
			}
			else
			{
				qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("battle", string.Empty)));
				qpihhqdnqgd.POLLCNHCQQC = "WATER_SIMPLE";
				qpihhqdnqgd.BGDGEKEKOIE = text.Replace("special", string.Empty);
			}
		}
		if (qpihhqdnqgd.BGDGEKEKOIE == string.Empty)
		{
			qpihhqdnqgd.BGDGEKEKOIE = PIDLOFMIEFQ;
			qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(PIDLOFMIEFQ);
		}
		return qpihhqdnqgd;
	}

	// Token: 0x06002F68 RID: 12136 RVA: 0x0014D70C File Offset: 0x0014B90C
	public EODGHGDGKLC IHEDCMJFMCI(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.IFPHQQEQBKJ.Length; i++)
		{
			if (this.IFPHQQEQBKJ[i] != null && this.IFPHQQEQBKJ[i].name == "BB:" + HHNBICLDQKI)
			{
				return this.IFPHQQEQBKJ[i].GetComponent<EODGHGDGKLC>();
			}
		}
		for (int j = 0; j < this.IFPHQQEQBKJ.Length; j++)
		{
			if (this.IFPHQQEQBKJ[j] == null)
			{
				EODGHGDGKLC eodghgdgklc = this.OGQFOKGKONE(HHNBICLDQKI);
				this.IFPHQQEQBKJ[j] = eodghgdgklc.gameObject;
				return eodghgdgklc;
			}
		}
		return null;
	}

	// Token: 0x06002F69 RID: 12137 RVA: 0x0001583F File Offset: 0x00013A3F
	private void MBKJBIQKPGF()
	{
		this.CLKPCHGNCPQ = new string[5];
		this.GMQKGNOMIGD = new string[3];
	}

	// Token: 0x06002F6A RID: 12138 RVA: 0x00144D7C File Offset: 0x00142F7C
	public IEnumerator GHLKJKLJGKL(Battle CFHEIICNLFD)
	{
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) || CFHEIICNLFD.BattleID == OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH || OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH <= 0 || !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.CHGQGQOEEQC = CFHEIICNLFD.CanCatch;
			if (!this.CEFOLQBGEJG && CFHEIICNLFD.Request1 == null && CFHEIICNLFD.Request2 == null)
			{
				if (this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
				{
					yield break;
				}
			}
			if (!this.CEFOLQBGEJG)
			{
				this.ECJEIQPGMPO = null;
				this.LGOJEHFKLCL = null;
				this.OOKMKQFENFK = CFHEIICNLFD.BackgroundID;
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
				this.BFPKBMKGDEJ = false;
				this.CLKPCHGNCPQ = new string[6];
				this.GMQKGNOMIGD = new string[6];
				this.EDKQQKOCHPK = 1;
				if (CFHEIICNLFD.Mapping1 != null)
				{
					for (int i = 0; i < CFHEIICNLFD.Mapping1.Length; i++)
					{
						if (CFHEIICNLFD.Mapping1[i].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 1;
						}
					}
				}
				if (CFHEIICNLFD.Mapping2 != null)
				{
					for (int j = 0; j < CFHEIICNLFD.Mapping2.Length; j++)
					{
						if (CFHEIICNLFD.Mapping2[j].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 2;
						}
					}
				}
				this.BFPKBMKGDEJ = false;
			}
			if (CFHEIICNLFD.Mapping1 != null)
			{
				int num4 = 0;
				while (num4 < CFHEIICNLFD.Mapping1.Length && num4 < 3)
				{
					if (this.EDKQQKOCHPK == 1)
					{
						this.CLKPCHGNCPQ[num4] = CFHEIICNLFD.Mapping1[num4];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.CLKPCHGNCPQ[num4] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num4].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num4] = CFHEIICNLFD.Mapping1[num4];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.GMQKGNOMIGD[num4] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num4].trainer;
						}
					}
					num4++;
				}
			}
			if (CFHEIICNLFD.Mapping2 != null)
			{
				int num5 = 0;
				while (num5 < CFHEIICNLFD.Mapping2.Length && num5 < 3)
				{
					if (this.EDKQQKOCHPK == 2)
					{
						this.CLKPCHGNCPQ[num5] = CFHEIICNLFD.Mapping2[num5];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.CLKPCHGNCPQ[num5] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num5].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num5] = CFHEIICNLFD.Mapping2[num5];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.GMQKGNOMIGD[num5] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num5].trainer;
						}
					}
					num5++;
				}
			}
			if (!this.QHLPMOPOBNJ)
			{
				this.QHLPMOPOBNJ = true;
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = true;
				}
				battleRequest = null;
				battleRequest2 = null;
				if (this.EDKQQKOCHPK == 1)
				{
					battleRequest = CFHEIICNLFD.Request1;
					battleRequest2 = CFHEIICNLFD.Request2;
				}
				else
				{
					battleRequest = CFHEIICNLFD.Request2;
					battleRequest2 = CFHEIICNLFD.Request1;
				}
				num3 = 0;
				if (!this.CEFOLQBGEJG && CFHEIICNLFD.Log != null)
				{
					foreach (string text in CFHEIICNLFD.Log)
					{
						num3++;
						string[] array = text.Split(new char[]
						{
							'|'
						});
						if (array.Length > 1)
						{
							string text2 = array[1];
							if (text2 != null && text2 == "switch" && (num3 + 1 >= CFHEIICNLFD.Log.Length || CFHEIICNLFD.Log[num3 + 1].Length <= 10 || !(CFHEIICNLFD.Log[num3 + 1].Substring(0, 10) == text.Substring(0, 10))))
							{
								string text3 = string.Empty;
								string s = string.Empty;
								DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk;
								if (array.Length >= 7)
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], array[4]);
									text3 = array[5];
									s = array[6];
								}
								else
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], string.Empty);
									text3 = array[4];
									s = array[5];
								}
								DBQLOHBBJMG.EFQENJNJIEF efqenjnjief = this.LMHQBCEBPHG(array[2]);
								int qkneijqhgcb = 0;
								int.TryParse(s, out qkneijqhgcb);
								OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
								mffgqcjkpbd.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD.ToString();
								mffgqcjkpbd.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
								mffgqcjkpbd.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
								mffgqcjkpbd.QKNEIJQHGCB = qkneijqhgcb;
								if (efqenjnjief.MLKGPDPKKCE == 0)
								{
									if (this.ECJEIQPGMPO == null)
									{
										this.ECJEIQPGMPO = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
								else
								{
									if (this.LGOJEHFKLCL == null)
									{
										this.LGOJEHFKLCL = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
							}
						}
					}
				}
				if (battleRequest != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest, CFHEIICNLFD.BattleID));
				}
				else if (battleRequest2 != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest2, CFHEIICNLFD.BattleID));
				}
				else if (CFHEIICNLFD.Log != null)
				{
					yield return base.StartCoroutine(this.HIHHCNIPPHL(CFHEIICNLFD.Log, false, battleRequest, battleRequest2));
				}
				else
				{
					if (!this.CEFOLQBGEJG)
					{
						OGJJKKQPNMK qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
						if (qoqonhoolne != null)
						{
							qoqonhoolne.POKGLNOCHJE = UnityEngine.Time.time;
							if (CFHEIICNLFD.Timer > 0)
							{
								qoqonhoolne.MHKFGIGILMB = (float)CFHEIICNLFD.Timer;
								qoqonhoolne.JJJGDPOKQPP = true;
							}
							else
							{
								qoqonhoolne.JJJGDPOKQPP = false;
								qoqonhoolne.MHKFGIGILMB = 90f;
							}
							qoqonhoolne.FCMNJOPQBKQ = CFHEIICNLFD.CanEscape;
							qoqonhoolne.LJDIQKPJIJN = CFHEIICNLFD.CanUseItem;
							qoqonhoolne.GHQOEDBJDNI = CFHEIICNLFD.CanCatch;
						}
					}
					if (this.DMIEIKIPDII)
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.POKGLNOCHJE = UnityEngine.Time.time;
						}
						this.DMIEIKIPDII = false;
					}
					if (!this.CEFOLQBGEJG)
					{
						this.CEFOLQBGEJG = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							for (int l = 0; l < OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE.Length; l++)
							{
								if (this.CBDCGKPHPJO != null)
								{
									this.CBDCGKPHPJO[l].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.KMNQBFKKNMB;
									this.CBDCGKPHPJO[l].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.CBDCGKPHPJO[l].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.EOMPMQNGIBD;
									this.CBDCGKPHPJO[l].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.HHNOCOQJOJF;
									this.CBDCGKPHPJO[l].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.QKNEIJQHGCB;
									this.CBDCGKPHPJO[l].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DBPKNCDGGEP;
									this.CBDCGKPHPJO[l].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.PLCBFLQBCQN;
									this.CBDCGKPHPJO[l].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.BKNFHNFFCHE;
									this.CBDCGKPHPJO[l].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
							for (int m = 0; m < OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI.Length; m++)
							{
								if (this.JELLELLGLLB != null)
								{
									this.JELLELLGLLB[m].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.KMNQBFKKNMB;
									this.JELLELLGLLB[m].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.JELLELLGLLB[m].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.EOMPMQNGIBD;
									this.JELLELLGLLB[m].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.HHNOCOQJOJF;
									this.JELLELLGLLB[m].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.QKNEIJQHGCB;
									this.JELLELLGLLB[m].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DBPKNCDGGEP;
									this.JELLELLGLLB[m].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.PLCBFLQBCQN;
									this.JELLELLGLLB[m].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.BKNFHNFFCHE;
									this.JELLELLGLLB[m].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
						}
					}
					this.DMIEIKIPDII = false;
					if (battleRequest == null && battleRequest2 == null && this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						}
					}
					else if (OGJJKKQPNMK.QOQONHOOLNE != null)
					{
						OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH = 0;
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						OGJJKKQPNMK.QOQONHOOLNE.PDDJMNOOPJD(false);
					}
					if (CFHEIICNLFD.Ended && !this.BFPKBMKGDEJ)
					{
						this.BFPKBMKGDEJ = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							yield return base.StartCoroutine(OGJJKKQPNMK.QOQONHOOLNE.BDOQHKILDHC());
							return 1;
						}
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.MELOIMCMIGN();
					}
					this.NDEDPKOEDIB = false;
					this.QHLPMOPOBNJ = false;
					CNCJKLNHQBH.QOQONHOOLNE.MGFDFQDMGPG = null;
					yield return null;
				}
			}
			else
			{
				yield return false;
			}
		}
		else
		{
			yield return false;
		}
		return 1;
		yield break;
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x0014D7A8 File Offset: 0x0014B9A8
	private DBQLOHBBJMG.GQNLOLLCIEB FDLPBIDQDMC(string JBNFQFNOKHP)
	{
		DBQLOHBBJMG.GQNLOLLCIEB gqnlollcieb = new DBQLOHBBJMG.GQNLOLLCIEB();
		if (JBNFQFNOKHP.Length > 3)
		{
			if (JBNFQFNOKHP.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 1)
			{
				gqnlollcieb.DBPKNCDGGEP = 1;
				gqnlollcieb.FPQBICGEHMJ = this.GMQKGNOMIGD[0];
			}
			if (JBNFQFNOKHP.Substring(0, 2) == "p2" && this.EDKQQKOCHPK == 2)
			{
				gqnlollcieb.DBPKNCDGGEP = 0;
				gqnlollcieb.FPQBICGEHMJ = this.CLKPCHGNCPQ[0];
			}
			if (JBNFQFNOKHP.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 1)
			{
				gqnlollcieb.DBPKNCDGGEP = 0;
				gqnlollcieb.FPQBICGEHMJ = this.CLKPCHGNCPQ[0];
			}
			if (JBNFQFNOKHP.Substring(0, 2) == "p1" && this.EDKQQKOCHPK == 2)
			{
				gqnlollcieb.DBPKNCDGGEP = 1;
				gqnlollcieb.FPQBICGEHMJ = this.GMQKGNOMIGD[0];
			}
			if (gqnlollcieb.FPQBICGEHMJ != null && !(gqnlollcieb.FPQBICGEHMJ == string.Empty))
			{
				gqnlollcieb.FPQBICGEHMJ = "[ff6666]" + gqnlollcieb.FPQBICGEHMJ + "[-]'s Team";
			}
			else
			{
				gqnlollcieb.FPQBICGEHMJ = "[ff6666]Enemy[-]'s Team";
			}
			return gqnlollcieb;
		}
		return null;
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x000156B5 File Offset: 0x000138B5
	private bool MBKODHMOGLO(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.JNIMJICDKHK(IHIHHCCEDHQ);
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x0014D8D4 File Offset: 0x0014BAD4
	private DBQLOHBBJMG.PJELBGQDEFC HPKPEFPNBEB(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.PJELBGQDEFC pjelbgqdefc = new DBQLOHBBJMG.PJELBGQDEFC();
		char[] array = new char[0];
		array[1] = '2';
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		int i = 1;
		while (i < array3.Length)
		{
			string text = array3[i];
			if (text.Length < 107)
			{
				goto IL_248;
			}
			if (text.Substring(1, -68) == "<|>")
			{
				pjelbgqdefc.IJBDEJBECBH = false;
			}
			else if (text.Substring(1, 6) == "aquaring")
			{
				string[] array4 = text.Substring(121).Split(new string[]
				{
					"127.0.0.1"
				}, StringSplitOptions.RemoveEmptyEntries);
				pjelbgqdefc.QFDKFDHBPBF = new DBQLOHBBJMG.MDECBDPGEBO[array4.Length];
				int num = 1;
				string[] array5 = array4;
				for (int j = 1; j < array5.Length; j += 0)
				{
					string text2 = array5[j];
					pjelbgqdefc.QFDKFDHBPBF[num] = new DBQLOHBBJMG.MDECBDPGEBO();
					if (text2.Substring(7, 1) == "Will You Be My Valentine?")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text2.Substring(0, 1) == "'s perish count fell to 0.\r\n")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text2.Substring(3, 0) == "pickpocket")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					if (text2.Substring(0, 1) == "Only The Best!" && this.EDKQQKOCHPK == 0)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text2.Substring(1, 3) == "_1" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text2.Substring(1, 7) == "Restores HP as well when the Pokémon eats a Berry." && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text2.Substring(1, 0) == "Icon_Pokemon_Dead" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					num++;
				}
			}
			else if (text.Substring(1, 3) == "setsprite(")
			{
				string bchjnmcjphg = text.Substring(97);
				pjelbgqdefc.BCHJNMCJPHG = bchjnmcjphg;
			}
			else
			{
				if (!(text.Substring(1, 7) == "Right"))
				{
					goto IL_248;
				}
				pjelbgqdefc.EQOKIDDKCGO = true;
			}
			IL_791:
			i++;
			continue;
			IL_248:
			if (text.Length >= 7)
			{
				if (text.Substring(0, 8) == "2")
				{
					pjelbgqdefc.NJNGIIDHEGG = true;
					goto IL_791;
				}
				if (text.Substring(0, 5) == "Lv ")
				{
					pjelbgqdefc.DEPGENPNMCM = true;
					goto IL_791;
				}
				if (text.Substring(0, 1) == "s")
				{
					pjelbgqdefc.FHFOMOLCIPQ = true;
					goto IL_791;
				}
				if (text.Substring(0, 2) == "PrimitiveRearLeftCorner")
				{
					pjelbgqdefc.GMJJOGFDQBL = false;
					goto IL_791;
				}
				if (text.Substring(0, 6) == "happyhour")
				{
					pjelbgqdefc.IEJDINIGJNF = true;
					goto IL_791;
				}
			}
			if (text.Length >= 7)
			{
				if (text.Substring(1, 7) == "#")
				{
					pjelbgqdefc.MMJOCGHBFOM = false;
					goto IL_791;
				}
				if (text.Substring(0, 8) == "'s Natural Cure activated!\r\n")
				{
					pjelbgqdefc.NFPKBFPEPLJ = false;
					goto IL_791;
				}
			}
			if (text.Length >= 7 && text.Substring(1, 8) == "BuffIcon_HailstormEncounterDecreased")
			{
				string text3 = text.Substring(7);
				if (text3.Length > 1 && text3.Substring(1, 0) == "fairyaura")
				{
					text3 = text3.Substring(1);
				}
				if (text3.Contains("More Bites!") || this.NEGFDQJKGKC(text3.Replace("Login", string.Empty)))
				{
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text3.Replace("HidePanel", string.Empty)));
					pjelbgqdefc.CGHQEHCBQHB = KGQECFKLKOP.DPDPPDNIFQN(pjelbgqdefc.KQENJEENGNH);
					goto IL_791;
				}
				if (text3.Contains("Head") || this.NOIKMKLNKNJ(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("The effects of the weather disappeared.\r\n", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.MKLJBFIJNND(text3.Replace(",", string.Empty));
					goto IL_791;
				}
				if (text3.Contains("embargo") || this.KCIFMQCEOKF(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("[itm=", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text3.Replace(" (TextureClip)", string.Empty));
					goto IL_791;
				}
				if (text3.Contains("ability") || this.LDMEEDNHPMN(text3))
				{
					pjelbgqdefc.CGHQEHCBQHB = text3.Replace("Boosts the Attack stat if hit by a Grass-type move, instead of taking damage.", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(text3.Replace("Lv ", string.Empty));
					goto IL_791;
				}
				goto IL_791;
			}
			else
			{
				if (text.Length >= 1 && text.Substring(0, 7) == "UpdateTweenPosition")
				{
					pjelbgqdefc.FHFQGFHIBOM = true;
					goto IL_791;
				}
				if (text.Length >= 0 && text.Substring(1, 4) == "Prevents opposing Pokémon from fleeing.")
				{
					pjelbgqdefc.DMLODDCIEQN = true;
					goto IL_791;
				}
				if (text.Length >= 1 && text.Substring(1, 2) == "\r\nSPD")
				{
					pjelbgqdefc.DPIIMQEDCEE = true;
					goto IL_791;
				}
				if (text.Length >= 3 && text.Substring(0, 1) == "CombinersArgsColorSrc0")
				{
					if (text.Substring(7).Length >= 8)
					{
						pjelbgqdefc.QDLONHBDODI = this.IDDCFDJILGG(text.Substring(7));
						goto IL_791;
					}
					goto IL_791;
				}
				else
				{
					if (text == "fdata")
					{
						pjelbgqdefc.QHLIEEGQIDQ = false;
						goto IL_791;
					}
					if (text.ToLowerInvariant() == "ability: ")
					{
						pjelbgqdefc.KMNMKEIOGFI = true;
						goto IL_791;
					}
					if (!(text != array2[1]) || !(text != array2[0]) || !(text != array2[6]))
					{
						goto IL_791;
					}
					if (text.Contains(")\n") || this.NEGFDQJKGKC(text.Replace("0", string.Empty)))
					{
						pjelbgqdefc.KDMEFLFNIOO = this.MKLJBFIJNND(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("Run_White", string.Empty)));
						pjelbgqdefc.POLLCNHCQQC = "127.0.0.1";
						pjelbgqdefc.BGDGEKEKOIE = text.Replace(" used the move instructed by ", string.Empty);
						goto IL_791;
					}
					if (text.Contains("Super Repel") || this.NNLLJMOCHBQ(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("\n", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("Duplicate!", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "Powers up Grass-type moves when the Pokémon's HP is low.";
						goto IL_791;
					}
					if (text.Contains("Water") || this.KCIFMQCEOKF(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace(",1+", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(text.Replace("Interact", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "Grass Pelt";
						goto IL_791;
					}
					if (text.Contains("Great Ball") || this.LDMEEDNHPMN(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("slushrush", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace("Monsters/", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "\n";
						goto IL_791;
					}
					goto IL_791;
				}
			}
		}
		return pjelbgqdefc;
	}

	// Token: 0x06002F6E RID: 12142 RVA: 0x0014E084 File Offset: 0x0014C284
	private DBQLOHBBJMG.QPIHHQDNQGD EIFQBLNFLDI(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.QPIHHQDNQGD qpihhqdnqgd = new DBQLOHBBJMG.QPIHHQDNQGD();
		char[] array = new char[0];
		array[1] = 'h';
		string[] array2 = PIDLOFMIEFQ.Split(array);
		foreach (string text in array2)
		{
			if (!text.Contains("\"") && !this.KPCKMMCQEEE(text.Replace("Hold or Use?", string.Empty)))
			{
				if (!text.Contains("Enabled") && !this.JPJIMJLEDPL(text))
				{
					if (!text.Contains(" ended!\r\n") && !this.BBJCKMLQOLH(text))
					{
						if (text.Contains("new npc") || this.LBBBBHNJPJO(text))
						{
							qpihhqdnqgd.BGDGEKEKOIE = text.Replace(" ", string.Empty);
							qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("Mouse Y", string.Empty));
							qpihhqdnqgd.POLLCNHCQQC = "Water";
						}
					}
					else
					{
						qpihhqdnqgd.BGDGEKEKOIE = text.Replace("Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_6_Light.mat", string.Empty);
						qpihhqdnqgd.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("recoil", string.Empty));
						qpihhqdnqgd.POLLCNHCQQC = " ";
					}
				}
				else
				{
					qpihhqdnqgd.BGDGEKEKOIE = text.Replace("[00EE07]", string.Empty);
					qpihhqdnqgd.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace("cheekpouch", string.Empty));
					qpihhqdnqgd.POLLCNHCQQC = "[damage]";
				}
			}
			else
			{
				qpihhqdnqgd.KDMEFLFNIOO = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("HideResponse", string.Empty)));
				qpihhqdnqgd.POLLCNHCQQC = "Open";
				qpihhqdnqgd.BGDGEKEKOIE = text.Replace("~", string.Empty);
			}
		}
		if (qpihhqdnqgd.BGDGEKEKOIE == string.Empty)
		{
			qpihhqdnqgd.BGDGEKEKOIE = PIDLOFMIEFQ;
			qpihhqdnqgd.KDMEFLFNIOO = this.QFLBJNELCBI(PIDLOFMIEFQ);
		}
		return qpihhqdnqgd;
	}

	// Token: 0x06002F6F RID: 12143 RVA: 0x00147BEC File Offset: 0x00145DEC
	public IEnumerator JOONGJPBKHC(BattleRequest BJGCBDNBQCJ, int HNJJPCMFBGN)
	{
		qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
		if ((BJGCBDNBQCJ.Player == "p1" && this.EDKQQKOCHPK == 1) || (BJGCBDNBQCJ.Player == "p2" && this.EDKQQKOCHPK == 2))
		{
			this.JFPJBDKKIOC = BJGCBDNBQCJ.RequestID;
			if (!this.CEFOLQBGEJG && BJGCBDNBQCJ.RequestInfo.active == null)
			{
				if (BJGCBDNBQCJ.RequestInfo.wait)
				{
					this.NDEDPKOEDIB = true;
				}
				num = 0;
				for (int i = 0; i < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; i++)
				{
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[i].active)
					{
						num++;
					}
				}
				yield return base.StartCoroutine(this.HGNOEQKEBQD());
				return 1;
			}
			if (BJGCBDNBQCJ.RequestInfo.active != null && BJGCBDNBQCJ.RequestInfo.active.Length > 0)
			{
				if (!this.CEFOLQBGEJG)
				{
					if (BJGCBDNBQCJ.RequestInfo.wait)
					{
						this.NDEDPKOEDIB = true;
					}
					yield return base.StartCoroutine(this.HGNOEQKEBQD());
					return 1;
				}
				array = new KGQECFKLKOP.GPFFQQMDFPB[BJGCBDNBQCJ.RequestInfo.active.Length];
				for (int j = 0; j < BJGCBDNBQCJ.RequestInfo.active.Length; j++)
				{
					array[j] = new KGQECFKLKOP.GPFFQQMDFPB();
					if (BJGCBDNBQCJ.RequestInfo.active[j].moves != null)
					{
						for (int k = 0; k < BJGCBDNBQCJ.RequestInfo.active[j].moves.Length; k++)
						{
							array[j].EEILBMOOJHJ[k] = new KGQECFKLKOP.EDHMLDLCFHC();
							array[j].EEILBMOOJHJ[k].DONPNIFGBBF = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].disabled;
							array[j].EEILBMOOJHJ[k].CIQFCJGQEMH = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].id;
							array[j].EEILBMOOJHJ[k].JPLIFCNPICK = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].maxpp;
							array[j].EEILBMOOJHJ[k].LIQCECMEOIJ = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].pp;
							array[j].EEILBMOOJHJ[k].FBCKQEDONJK = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].move;
							array[j].EEILBMOOJHJ[k].ILBCCCBJNCL = BJGCBDNBQCJ.RequestInfo.active[j].moves[k].target;
						}
					}
					array[j].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.active[j].trainer;
					if (array[j].HHNOCOQJOJF == null)
					{
						array[j].HHNOCOQJOJF = "NPC";
					}
					array[j].BPHKNGMPLML = BJGCBDNBQCJ.RequestInfo.active[j].trapped;
					array[j].FGQHEDFQIFC = BJGCBDNBQCJ.RequestInfo.active[j].maybeTrapped;
					array[j].OEBEBPJEINC = BJGCBDNBQCJ.RequestInfo.active[j].canMegaEvo;
					qoqonhoolne.CLBGINEMIFE[j].HHKJGOPMMQL = array[j];
				}
				for (int l = 0; l < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; l++)
				{
					if (l < qoqonhoolne.CLBGINEMIFE.Length && qoqonhoolne.CLBGINEMIFE[l] != null)
					{
						qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].active;
						qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.BHPMOFEKHPM = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].baseAbility;
						if (!this.CEFOLQBGEJG && BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moves != null && BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData != null)
						{
							for (int m = 0; m < BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moves.Length; m++)
							{
								if (qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ != null && qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m] != null && qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].FBCKQEDONJK == BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].move)
								{
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].CIQFCJGQEMH = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].id;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].JPLIFCNPICK = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].maxpp;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].LIQCECMEOIJ = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].pp;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].FBCKQEDONJK = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].move;
									qoqonhoolne.CLBGINEMIFE[l].HHKJGOPMMQL.EEILBMOOJHJ[m].ILBCCCBJNCL = BJGCBDNBQCJ.RequestInfo.side.pokemon[l].moveData[m].target;
								}
							}
						}
					}
				}
			}
			IL_13D2:
			if (BJGCBDNBQCJ.RequestInfo.side.pokemon.Length > 0)
			{
				qoqonhoolne.IGOGQDBOGQL = BJGCBDNBQCJ.RequestInfo.side;
				int num2 = 0;
				for (int n = 0; n < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; n++)
				{
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[n].trainer != null && BJGCBDNBQCJ.RequestInfo.side.pokemon[n].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num2++;
					}
				}
				qoqonhoolne.OEDNKPKCFJI = new KGQECFKLKOP.GPFFQQMDFPB[num2];
				num2 = 0;
				for (int num3 = 0; num3 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num3++)
				{
					KGQECFKLKOP.GPFFQQMDFPB gpffqqmdfpb = new KGQECFKLKOP.GPFFQQMDFPB();
					DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].condition);
					gpffqqmdfpb.BHPMOFEKHPM = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].baseAbility;
					gpffqqmdfpb.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].active;
					gpffqqmdfpb.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
					gpffqqmdfpb.BKNFHNFFCHE = qqkkgejlmlk.BKNFHNFFCHE;
					gpffqqmdfpb.DCFKMOILHEC = qqkkgejlmlk.DCFKMOILHEC;
					gpffqqmdfpb.DBPKNCDGGEP = qqkkgejlmlk.DBPKNCDGGEP;
					gpffqqmdfpb.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD;
					gpffqqmdfpb.QKBGGCKIOLG = qqkkgejlmlk.QKBGGCKIOLG;
					gpffqqmdfpb.KMNQBFKKNMB = qqkkgejlmlk.KMNQBFKKNMB;
					gpffqqmdfpb.HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer;
					if (gpffqqmdfpb.HHNOCOQJOJF == null)
					{
						gpffqqmdfpb.HHNOCOQJOJF = "NPC";
					}
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves != null)
					{
						gpffqqmdfpb.EEILBMOOJHJ = new KGQECFKLKOP.EDHMLDLCFHC[BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves.Length];
						for (int num4 = 0; num4 < BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves.Length; num4++)
						{
							gpffqqmdfpb.EEILBMOOJHJ[num4] = new KGQECFKLKOP.EDHMLDLCFHC();
							gpffqqmdfpb.EEILBMOOJHJ[num4].CIQFCJGQEMH = KGQECFKLKOP.FMLPNPFKFLM(BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moveData[num4].id);
							gpffqqmdfpb.EEILBMOOJHJ[num4].JPLIFCNPICK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moveData[num4].maxpp;
							gpffqqmdfpb.EEILBMOOJHJ[num4].LIQCECMEOIJ = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moveData[num4].pp;
							gpffqqmdfpb.EEILBMOOJHJ[num4].FBCKQEDONJK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].moves[num4];
						}
					}
					OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
					mffgqcjkpbd.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD.ToString();
					mffgqcjkpbd.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
					mffgqcjkpbd.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
					mffgqcjkpbd.QKNEIJQHGCB = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].personality;
					gpffqqmdfpb.QKNEIJQHGCB = mffgqcjkpbd.QKNEIJQHGCB;
					gpffqqmdfpb.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
					if (num3 < qoqonhoolne.CLBGINEMIFE.Length && qoqonhoolne.CLBGINEMIFE[num3] != null)
					{
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.DBPKNCDGGEP = qqkkgejlmlk.DBPKNCDGGEP;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.BKNFHNFFCHE = qqkkgejlmlk.BKNFHNFFCHE;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.DCFKMOILHEC = qqkkgejlmlk.DCFKMOILHEC;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.QKBGGCKIOLG = qqkkgejlmlk.QKBGGCKIOLG;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.KMNQBFKKNMB = qqkkgejlmlk.KMNQBFKKNMB;
						qoqonhoolne.CLBGINEMIFE[num3].JKBEKOBJDBF = mffgqcjkpbd;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.QKNEIJQHGCB = mffgqcjkpbd.QKNEIJQHGCB;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
						qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer;
						if (qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.HHNOCOQJOJF == null)
						{
							qoqonhoolne.CLBGINEMIFE[num3].HHKJGOPMMQL.HHNOCOQJOJF = "NPC";
						}
					}
					if (BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer != null && BJGCBDNBQCJ.RequestInfo.side.pokemon[num3].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						qoqonhoolne.OEDNKPKCFJI[num2] = gpffqqmdfpb;
						num2++;
					}
				}
			}
			if (BJGCBDNBQCJ.RequestInfo.forceSwitch != null)
			{
				for (int num5 = 0; num5 < BJGCBDNBQCJ.RequestInfo.forceSwitch.Length; num5++)
				{
					if (num5 < qoqonhoolne.CLBGINEMIFE.Length && qoqonhoolne.CLBGINEMIFE[num5] != null)
					{
						qoqonhoolne.CLBGINEMIFE[num5].HHKJGOPMMQL.NEBPMMPMQBD = BJGCBDNBQCJ.RequestInfo.forceSwitch[num5];
						this.DMIEIKIPDII = true;
					}
				}
			}
			else
			{
				for (int num6 = 0; num6 < qoqonhoolne.CLBGINEMIFE.Length; num6++)
				{
					if (qoqonhoolne.CLBGINEMIFE[num6] != null)
					{
						qoqonhoolne.CLBGINEMIFE[num6].HHKJGOPMMQL.NEBPMMPMQBD = false;
					}
				}
			}
		}
		else if (qoqonhoolne != null)
		{
			if (!this.CEFOLQBGEJG)
			{
				if (BJGCBDNBQCJ.RequestInfo.active != null && BJGCBDNBQCJ.RequestInfo.active.Length > 0)
				{
					array = new KGQECFKLKOP.GPFFQQMDFPB[BJGCBDNBQCJ.RequestInfo.active.Length];
					for (int num7 = 0; num7 < BJGCBDNBQCJ.RequestInfo.active.Length; num7++)
					{
						array[num7] = new KGQECFKLKOP.GPFFQQMDFPB();
						array[num7].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.active[num7].trainer;
						if (array[num7].HHNOCOQJOJF == null)
						{
							array[num7].HHNOCOQJOJF = "NPC";
						}
						qoqonhoolne.JMCMGILPGGI[num7].HHKJGOPMMQL = array[num7];
					}
				}
				else
				{
					int num8 = 0;
					for (int num9 = 0; num9 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num9++)
					{
						if (BJGCBDNBQCJ.RequestInfo.side.pokemon[num9].active)
						{
							num8++;
						}
					}
					array = new KGQECFKLKOP.GPFFQQMDFPB[num8];
					for (int num10 = 0; num10 < num8; num10++)
					{
						array[num10] = new KGQECFKLKOP.GPFFQQMDFPB();
						array[num10].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num10].trainer;
						if (array[num10].HHNOCOQJOJF == null)
						{
							array[num10].HHNOCOQJOJF = "NPC";
						}
						qoqonhoolne.JMCMGILPGGI[num10].HHKJGOPMMQL = array[num10];
					}
				}
				this.LOGEQNIDFBJ = 0;
				this.BNNGMBEHDDC = 0;
				if (BJGCBDNBQCJ.RequestInfo.side.pokemon != null)
				{
					for (int num11 = 0; num11 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num11++)
					{
						if (num11 < qoqonhoolne.JMCMGILPGGI.Length && qoqonhoolne.JMCMGILPGGI[num11] != null)
						{
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].active;
							DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk2 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].condition);
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.DBPKNCDGGEP = qqkkgejlmlk2.DBPKNCDGGEP;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.BKNFHNFFCHE = qqkkgejlmlk2.BKNFHNFFCHE;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.DCFKMOILHEC = qqkkgejlmlk2.DCFKMOILHEC;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.QKBGGCKIOLG = qqkkgejlmlk2.QKBGGCKIOLG;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.KMNQBFKKNMB = qqkkgejlmlk2.KMNQBFKKNMB;
							OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd2 = new OELLFMKIMFH.MFFGQCJKPBD();
							mffgqcjkpbd2.EOMPMQNGIBD = qqkkgejlmlk2.EOMPMQNGIBD.ToString();
							mffgqcjkpbd2.OQDOCCGPJDQ = qqkkgejlmlk2.OQDOCCGPJDQ;
							mffgqcjkpbd2.PLCBFLQBCQN = qqkkgejlmlk2.PLCBFLQBCQN;
							mffgqcjkpbd2.QKNEIJQHGCB = BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].personality;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.PLCBFLQBCQN = qqkkgejlmlk2.PLCBFLQBCQN;
							qoqonhoolne.JMCMGILPGGI[num11].JKBEKOBJDBF = mffgqcjkpbd2;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.EOMPMQNGIBD = qqkkgejlmlk2.EOMPMQNGIBD;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.QKNEIJQHGCB = mffgqcjkpbd2.QKNEIJQHGCB;
							qoqonhoolne.JMCMGILPGGI[num11].HHKJGOPMMQL.OQDOCCGPJDQ = qqkkgejlmlk2.OQDOCCGPJDQ;
						}
						DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk3 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num11].condition);
						if (qqkkgejlmlk3.DCFKMOILHEC <= 0)
						{
							if (qqkkgejlmlk3.DBPKNCDGGEP > 0)
							{
								this.BNNGMBEHDDC++;
							}
						}
						else if (qqkkgejlmlk3.DBPKNCDGGEP > 0)
						{
							this.LOGEQNIDFBJ++;
						}
					}
				}
				for (int num12 = 0; num12 < 18; num12++)
				{
					qoqonhoolne.BDQLIFLICNM[num12].DIIHJCJOKMP = 0f;
				}
				for (int num13 = 0; num13 < this.LOGEQNIDFBJ; num13++)
				{
					if (num13 < 18)
					{
						qoqonhoolne.BDQLIFLICNM[num13].DIIHJCJOKMP = 1f;
						qoqonhoolne.BDQLIFLICNM[num13].KCLBMPFIPNQ = "Icon_Pokemon_Alive";
					}
				}
				for (int num14 = 0; num14 < this.BNNGMBEHDDC; num14++)
				{
					if (num14 + this.LOGEQNIDFBJ < 18)
					{
						qoqonhoolne.BDQLIFLICNM[num14 + this.LOGEQNIDFBJ].DIIHJCJOKMP = 1f;
						qoqonhoolne.BDQLIFLICNM[num14 + this.LOGEQNIDFBJ].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
					}
				}
				yield return base.StartCoroutine(qoqonhoolne.LPFFHKLCGLM(this.NDEDPKOEDIB));
				return 1;
			}
			this.LOGEQNIDFBJ = 0;
			this.BNNGMBEHDDC = 0;
			for (int num15 = 0; num15 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length; num15++)
			{
				if (num15 < qoqonhoolne.JMCMGILPGGI.Length && qoqonhoolne.JMCMGILPGGI[num15] != null)
				{
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].active;
					DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk4 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].condition);
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.DBPKNCDGGEP = qqkkgejlmlk4.DBPKNCDGGEP;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.BKNFHNFFCHE = qqkkgejlmlk4.BKNFHNFFCHE;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.DCFKMOILHEC = qqkkgejlmlk4.DCFKMOILHEC;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.QKBGGCKIOLG = qqkkgejlmlk4.QKBGGCKIOLG;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.KMNQBFKKNMB = qqkkgejlmlk4.KMNQBFKKNMB;
					OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd3 = new OELLFMKIMFH.MFFGQCJKPBD();
					mffgqcjkpbd3.EOMPMQNGIBD = qqkkgejlmlk4.EOMPMQNGIBD.ToString();
					mffgqcjkpbd3.OQDOCCGPJDQ = qqkkgejlmlk4.OQDOCCGPJDQ;
					mffgqcjkpbd3.PLCBFLQBCQN = qqkkgejlmlk4.PLCBFLQBCQN;
					mffgqcjkpbd3.QKNEIJQHGCB = BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].personality;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.PLCBFLQBCQN = qqkkgejlmlk4.PLCBFLQBCQN;
					qoqonhoolne.JMCMGILPGGI[num15].JKBEKOBJDBF = mffgqcjkpbd3;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.EOMPMQNGIBD = qqkkgejlmlk4.EOMPMQNGIBD;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.QKNEIJQHGCB = mffgqcjkpbd3.QKNEIJQHGCB;
					qoqonhoolne.JMCMGILPGGI[num15].HHKJGOPMMQL.OQDOCCGPJDQ = qqkkgejlmlk4.OQDOCCGPJDQ;
				}
				DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk5 = this.IGPLNJBJNCB(BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].details, BJGCBDNBQCJ.RequestInfo.side.pokemon[num15].condition);
				if (qqkkgejlmlk5.DCFKMOILHEC <= 0)
				{
					if (qqkkgejlmlk5.DBPKNCDGGEP > 0)
					{
						this.BNNGMBEHDDC++;
					}
				}
				else if (qqkkgejlmlk5.DBPKNCDGGEP > 0)
				{
					this.LOGEQNIDFBJ++;
				}
			}
		}
		yield return null;
		return 1;
		qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
		qoqonhoolne.HHEJQOGQEBH = HNJJPCMFBGN;
		qoqonhoolne.gameObject.SetActive(true);
		yield return base.StartCoroutine(qoqonhoolne.BQLIIQIIMDH(num));
		return 1;
		array = new KGQECFKLKOP.GPFFQQMDFPB[num];
		int num16 = 0;
		goto IL_CCE;
		IL_BC1:
		array[num16] = new KGQECFKLKOP.GPFFQQMDFPB();
		int num17 = 0;
		goto IL_C1C;
		IL_BD2:
		array[num16].EEILBMOOJHJ[num17] = new KGQECFKLKOP.EDHMLDLCFHC();
		array[num16].EEILBMOOJHJ[num17].CIQFCJGQEMH = BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].moves[num17];
		num17++;
		IL_C1C:
		if (num17 < BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].moves.Length)
		{
			goto IL_BD2;
		}
		array[num16].HHNOCOQJOJF = BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].trainer;
		if (array[num16].HHNOCOQJOJF != null)
		{
			goto IL_C87;
		}
		array[num16].HHNOCOQJOJF = "NPC";
		IL_C87:
		array[num16].BHPMOFEKHPM = BJGCBDNBQCJ.RequestInfo.side.pokemon[num16].baseAbility;
		qoqonhoolne.CLBGINEMIFE[num16].HHKJGOPMMQL = array[num16];
		num16++;
		IL_CCE:
		if (num16 < num)
		{
			goto IL_BC1;
		}
		int num18 = 0;
		goto IL_D41;
		IL_CDF:
		if (num18 >= qoqonhoolne.CLBGINEMIFE.Length || !(qoqonhoolne.CLBGINEMIFE[num18] != null))
		{
			goto IL_D3B;
		}
		qoqonhoolne.CLBGINEMIFE[num18].HHKJGOPMMQL.CPOJBKCQPHK = BJGCBDNBQCJ.RequestInfo.side.pokemon[num18].active;
		IL_D3B:
		num18++;
		IL_D41:
		if (num18 < BJGCBDNBQCJ.RequestInfo.side.pokemon.Length)
		{
			goto IL_CDF;
		}
		goto IL_13D2;
		qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
		qoqonhoolne.HHEJQOGQEBH = HNJJPCMFBGN;
		qoqonhoolne.gameObject.SetActive(true);
		yield return base.StartCoroutine(qoqonhoolne.BQLIIQIIMDH(BJGCBDNBQCJ.RequestInfo.active.Length));
		return 1;
		yield break;
	}

	// Token: 0x06002F70 RID: 12144 RVA: 0x000157E5 File Offset: 0x000139E5
	public static DBQLOHBBJMG IECKOKEPENM()
	{
		return DBQLOHBBJMG.HBFFCJHOCPE;
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06002F71 RID: 12145 RVA: 0x000157E5 File Offset: 0x000139E5
	public static DBQLOHBBJMG QOQONHOOLNE
	{
		get
		{
			return DBQLOHBBJMG.HBFFCJHOCPE;
		}
	}

	// Token: 0x06002F72 RID: 12146 RVA: 0x000157E5 File Offset: 0x000139E5
	public static DBQLOHBBJMG DQLDEKPLECH()
	{
		return DBQLOHBBJMG.HBFFCJHOCPE;
	}

	// Token: 0x06002F74 RID: 12148 RVA: 0x000157E5 File Offset: 0x000139E5
	public static DBQLOHBBJMG ODJQHLJCFGH()
	{
		return DBQLOHBBJMG.HBFFCJHOCPE;
	}

	// Token: 0x06002F75 RID: 12149 RVA: 0x00144D7C File Offset: 0x00142F7C
	public IEnumerator HBNHEKDHILH(Battle CFHEIICNLFD)
	{
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) || CFHEIICNLFD.BattleID == OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH || OGJJKKQPNMK.QOQONHOOLNE.HHEJQOGQEBH <= 0 || !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.CHGQGQOEEQC = CFHEIICNLFD.CanCatch;
			if (!this.CEFOLQBGEJG && CFHEIICNLFD.Request1 == null && CFHEIICNLFD.Request2 == null)
			{
				if (this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
				{
					yield break;
				}
			}
			if (!this.CEFOLQBGEJG)
			{
				this.ECJEIQPGMPO = null;
				this.LGOJEHFKLCL = null;
				this.OOKMKQFENFK = CFHEIICNLFD.BackgroundID;
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
				this.BFPKBMKGDEJ = false;
				this.CLKPCHGNCPQ = new string[6];
				this.GMQKGNOMIGD = new string[6];
				this.EDKQQKOCHPK = 1;
				if (CFHEIICNLFD.Mapping1 != null)
				{
					for (int i = 0; i < CFHEIICNLFD.Mapping1.Length; i++)
					{
						if (CFHEIICNLFD.Mapping1[i].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 1;
						}
					}
				}
				if (CFHEIICNLFD.Mapping2 != null)
				{
					for (int j = 0; j < CFHEIICNLFD.Mapping2.Length; j++)
					{
						if (CFHEIICNLFD.Mapping2[j].ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.EDKQQKOCHPK = 2;
						}
					}
				}
				this.BFPKBMKGDEJ = false;
			}
			if (CFHEIICNLFD.Mapping1 != null)
			{
				int num4 = 0;
				while (num4 < CFHEIICNLFD.Mapping1.Length && num4 < 3)
				{
					if (this.EDKQQKOCHPK == 1)
					{
						this.CLKPCHGNCPQ[num4] = CFHEIICNLFD.Mapping1[num4];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.CLKPCHGNCPQ[num4] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num4].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num4] = CFHEIICNLFD.Mapping1[num4];
						if (CFHEIICNLFD.Request1 != null && CFHEIICNLFD.Request1.RequestInfo.side != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request1.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping1.Length)
						{
							this.GMQKGNOMIGD[num4] = CFHEIICNLFD.Request1.RequestInfo.side.pokemon[num4].trainer;
						}
					}
					num4++;
				}
			}
			if (CFHEIICNLFD.Mapping2 != null)
			{
				int num5 = 0;
				while (num5 < CFHEIICNLFD.Mapping2.Length && num5 < 3)
				{
					if (this.EDKQQKOCHPK == 2)
					{
						this.CLKPCHGNCPQ[num5] = CFHEIICNLFD.Mapping2[num5];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.CLKPCHGNCPQ[num5] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num5].trainer;
						}
					}
					else
					{
						this.GMQKGNOMIGD[num5] = CFHEIICNLFD.Mapping2[num5];
						if (CFHEIICNLFD.Request2 != null && CFHEIICNLFD.Request2.RequestInfo.side != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon != null && CFHEIICNLFD.Request2.RequestInfo.side.pokemon.Length >= CFHEIICNLFD.Mapping2.Length)
						{
							this.GMQKGNOMIGD[num5] = CFHEIICNLFD.Request2.RequestInfo.side.pokemon[num5].trainer;
						}
					}
					num5++;
				}
			}
			if (!this.QHLPMOPOBNJ)
			{
				this.QHLPMOPOBNJ = true;
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = true;
				}
				battleRequest = null;
				battleRequest2 = null;
				if (this.EDKQQKOCHPK == 1)
				{
					battleRequest = CFHEIICNLFD.Request1;
					battleRequest2 = CFHEIICNLFD.Request2;
				}
				else
				{
					battleRequest = CFHEIICNLFD.Request2;
					battleRequest2 = CFHEIICNLFD.Request1;
				}
				num3 = 0;
				if (!this.CEFOLQBGEJG && CFHEIICNLFD.Log != null)
				{
					foreach (string text in CFHEIICNLFD.Log)
					{
						num3++;
						string[] array = text.Split(new char[]
						{
							'|'
						});
						if (array.Length > 1)
						{
							string text2 = array[1];
							if (text2 != null && text2 == "switch" && (num3 + 1 >= CFHEIICNLFD.Log.Length || CFHEIICNLFD.Log[num3 + 1].Length <= 10 || !(CFHEIICNLFD.Log[num3 + 1].Substring(0, 10) == text.Substring(0, 10))))
							{
								string text3 = string.Empty;
								string s = string.Empty;
								DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk;
								if (array.Length >= 7)
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], array[4]);
									text3 = array[5];
									s = array[6];
								}
								else
								{
									qqkkgejlmlk = this.IGPLNJBJNCB(array[3], string.Empty);
									text3 = array[4];
									s = array[5];
								}
								DBQLOHBBJMG.EFQENJNJIEF efqenjnjief = this.LMHQBCEBPHG(array[2]);
								int qkneijqhgcb = 0;
								int.TryParse(s, out qkneijqhgcb);
								OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
								mffgqcjkpbd.EOMPMQNGIBD = qqkkgejlmlk.EOMPMQNGIBD.ToString();
								mffgqcjkpbd.OQDOCCGPJDQ = qqkkgejlmlk.OQDOCCGPJDQ;
								mffgqcjkpbd.PLCBFLQBCQN = qqkkgejlmlk.PLCBFLQBCQN;
								mffgqcjkpbd.QKNEIJQHGCB = qkneijqhgcb;
								if (efqenjnjief.MLKGPDPKKCE == 0)
								{
									if (this.ECJEIQPGMPO == null)
									{
										this.ECJEIQPGMPO = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.ECJEIQPGMPO[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.CLKPCHGNCPQ[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
								else
								{
									if (this.LGOJEHFKLCL == null)
									{
										this.LGOJEHFKLCL = new DBQLOHBBJMG.NPJODDPEEQF[3];
									}
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP] = new DBQLOHBBJMG.NPJODDPEEQF();
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].JMDLLJPEFKM = qqkkgejlmlk;
									this.LGOJEHFKLCL[efqenjnjief.QEPKKJKQMPP].NMNMCGQPOPG = mffgqcjkpbd;
									if (text3 != null && text3 != string.Empty)
									{
										this.GMQKGNOMIGD[efqenjnjief.QEPKKJKQMPP] = text3;
									}
								}
							}
						}
					}
				}
				if (battleRequest != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest, CFHEIICNLFD.BattleID));
				}
				else if (battleRequest2 != null)
				{
					yield return base.StartCoroutine(this.KPPFIHLMECC(battleRequest2, CFHEIICNLFD.BattleID));
				}
				else if (CFHEIICNLFD.Log != null)
				{
					yield return base.StartCoroutine(this.HIHHCNIPPHL(CFHEIICNLFD.Log, false, battleRequest, battleRequest2));
				}
				else
				{
					if (!this.CEFOLQBGEJG)
					{
						OGJJKKQPNMK qoqonhoolne = OGJJKKQPNMK.QOQONHOOLNE;
						if (qoqonhoolne != null)
						{
							qoqonhoolne.POKGLNOCHJE = UnityEngine.Time.time;
							if (CFHEIICNLFD.Timer > 0)
							{
								qoqonhoolne.MHKFGIGILMB = (float)CFHEIICNLFD.Timer;
								qoqonhoolne.JJJGDPOKQPP = true;
							}
							else
							{
								qoqonhoolne.JJJGDPOKQPP = false;
								qoqonhoolne.MHKFGIGILMB = 90f;
							}
							qoqonhoolne.FCMNJOPQBKQ = CFHEIICNLFD.CanEscape;
							qoqonhoolne.LJDIQKPJIJN = CFHEIICNLFD.CanUseItem;
							qoqonhoolne.GHQOEDBJDNI = CFHEIICNLFD.CanCatch;
						}
					}
					if (this.DMIEIKIPDII)
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.POKGLNOCHJE = UnityEngine.Time.time;
						}
						this.DMIEIKIPDII = false;
					}
					if (!this.CEFOLQBGEJG)
					{
						this.CEFOLQBGEJG = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							for (int l = 0; l < OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE.Length; l++)
							{
								if (this.CBDCGKPHPJO != null)
								{
									this.CBDCGKPHPJO[l].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.KMNQBFKKNMB;
									this.CBDCGKPHPJO[l].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.CBDCGKPHPJO[l].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.EOMPMQNGIBD;
									this.CBDCGKPHPJO[l].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.HHNOCOQJOJF;
									this.CBDCGKPHPJO[l].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.QKNEIJQHGCB;
									this.CBDCGKPHPJO[l].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DBPKNCDGGEP;
									this.CBDCGKPHPJO[l].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.PLCBFLQBCQN;
									this.CBDCGKPHPJO[l].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.BKNFHNFFCHE;
									this.CBDCGKPHPJO[l].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.CLBGINEMIFE[l].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
							for (int m = 0; m < OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI.Length; m++)
							{
								if (this.JELLELLGLLB != null)
								{
									this.JELLELLGLLB[m].KMNQBFKKNMB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.KMNQBFKKNMB;
									this.JELLELLGLLB[m].OQDOCCGPJDQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.OQDOCCGPJDQ;
									this.JELLELLGLLB[m].EOMPMQNGIBD = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.EOMPMQNGIBD;
									this.JELLELLGLLB[m].FDGMQFNGKKL = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.HHNOCOQJOJF;
									this.JELLELLGLLB[m].QKNEIJQHGCB = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.QKNEIJQHGCB;
									this.JELLELLGLLB[m].BEQHNFFEHMQ = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DBPKNCDGGEP;
									this.JELLELLGLLB[m].PLCBFLQBCQN = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.PLCBFLQBCQN;
									this.JELLELLGLLB[m].BKNFHNFFCHE = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.BKNFHNFFCHE;
									this.JELLELLGLLB[m].DCFKMOILHEC = OGJJKKQPNMK.QOQONHOOLNE.JMCMGILPGGI[m].HHKJGOPMMQL.DCFKMOILHEC;
								}
							}
						}
					}
					this.DMIEIKIPDII = false;
					if (battleRequest == null && battleRequest2 == null && this.PBIPCKDMHBI(CFHEIICNLFD.Log, null, null))
					{
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						}
					}
					else if (OGJJKKQPNMK.QOQONHOOLNE != null)
					{
						OGJJKKQPNMK.QOQONHOOLNE.QHLPMOPOBNJ = false;
						OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH = 0;
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						if (!OGJJKKQPNMK.QOQONHOOLNE.LBIQLLNPCED(-1))
						{
							OGJJKKQPNMK.QOQONHOOLNE.FQBMEKNJHDH++;
						}
						OGJJKKQPNMK.QOQONHOOLNE.PDDJMNOOPJD(false);
					}
					if (CFHEIICNLFD.Ended && !this.BFPKBMKGDEJ)
					{
						this.BFPKBMKGDEJ = true;
						if (OGJJKKQPNMK.QOQONHOOLNE != null)
						{
							yield return base.StartCoroutine(OGJJKKQPNMK.QOQONHOOLNE.BDOQHKILDHC());
							return 1;
						}
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.MELOIMCMIGN();
					}
					this.NDEDPKOEDIB = false;
					this.QHLPMOPOBNJ = false;
					CNCJKLNHQBH.QOQONHOOLNE.MGFDFQDMGPG = null;
					yield return null;
				}
			}
			else
			{
				yield return false;
			}
		}
		else
		{
			yield return false;
		}
		return 1;
		yield break;
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x00142FA4 File Offset: 0x001411A4
	private IEnumerator CPBOCBDLFJO(string[] CBCFOFCLGCK, bool HMGPJBJQMOB = false, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		DBQLOHBBJMG.KFNKODBLFFM kfnkodblffm = new DBQLOHBBJMG.KFNKODBLFFM();
		kfnkodblffm.CBCFOFCLGCK = CBCFOFCLGCK;
		kfnkodblffm.BJGCBDNBQCJ = BJGCBDNBQCJ;
		kfnkodblffm.JEEJJGLGGMC = JEEJJGLGGMC;
		kfnkodblffm.QNDQJMNKFNN = this;
		return kfnkodblffm;
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x0014E2C0 File Offset: 0x0014C4C0
	public void JHMFBGHOMQB(BattleItem BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == BattleItemResult.Failed)
		{
			base.StartCoroutine(this.NEJKEQBQMOC("~" + KGQECFKLKOP.BFNBQBMJHFL(BJGCBDNBQCJ.Item).DFNQHDEDDKE() + "pickup", true));
			OGJJKKQPNMK.QOQONHOOLNE.KDMJOFNLBMB(false);
		}
		else
		{
			OGJJKKQPNMK.QOQONHOOLNE.DFIJJCBCKMD(true);
		}
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x00015859 File Offset: 0x00013A59
	private void JKNGPGGPMPG()
	{
		this.CLKPCHGNCPQ = new string[7];
		this.GMQKGNOMIGD = new string[8];
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x000157E5 File Offset: 0x000139E5
	public static DBQLOHBBJMG OQDOKBJNBBL()
	{
		return DBQLOHBBJMG.HBFFCJHOCPE;
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x00015873 File Offset: 0x00013A73
	public string FMLPNPFKFLM(string PIDLOFMIEFQ)
	{
		return Regex.Replace(PIDLOFMIEFQ, "[^a-zA-Z0-9_.]+", string.Empty, RegexOptions.Compiled).ToLowerInvariant();
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x00142F80 File Offset: 0x00141180
	public IEnumerator NEJKEQBQMOC(string PIDLOFMIEFQ, bool EFQMQOPCBNO = false)
	{
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("\r\n", string.Empty);
		if (OGJJKKQPNMK.QOQONHOOLNE != null && OGJJKKQPNMK.QOQONHOOLNE.gameObject.activeSelf)
		{
			OGJJKKQPNMK.QOQONHOOLNE.MLKGOQIEFHF(PIDLOFMIEFQ);
		}
		if (!EFQMQOPCBNO)
		{
			yield return new WaitForSeconds(0.8f);
		}
		else
		{
			yield return new WaitForSeconds(0.2f);
		}
		return 1;
		MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
		{
			Channel = "Battle",
			Messages = new PSXAPI.Response.Payload.ChatMessage[]
			{
				new PSXAPI.Response.Payload.ChatMessage
				{
					Message = PIDLOFMIEFQ,
					Timestamp = DateTime.Now,
					Username = string.Empty,
					Pokemon = null
				}
			}
		});
		yield break;
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x00142FA4 File Offset: 0x001411A4
	private IEnumerator CNBEOKIBOEI(string[] CBCFOFCLGCK, bool HMGPJBJQMOB = false, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		DBQLOHBBJMG.KFNKODBLFFM kfnkodblffm = new DBQLOHBBJMG.KFNKODBLFFM();
		kfnkodblffm.CBCFOFCLGCK = CBCFOFCLGCK;
		kfnkodblffm.BJGCBDNBQCJ = BJGCBDNBQCJ;
		kfnkodblffm.JEEJJGLGGMC = JEEJJGLGGMC;
		kfnkodblffm.QNDQJMNKFNN = this;
		return kfnkodblffm;
	}

	// Token: 0x06002F7D RID: 12157 RVA: 0x0014E31C File Offset: 0x0014C51C
	private DBQLOHBBJMG.GQNLOLLCIEB MOLBBMENKEO(string JBNFQFNOKHP)
	{
		DBQLOHBBJMG.GQNLOLLCIEB gqnlollcieb = new DBQLOHBBJMG.GQNLOLLCIEB();
		if (JBNFQFNOKHP.Length > 4)
		{
			if (JBNFQFNOKHP.Substring(1, 0) == "--idle" && this.EDKQQKOCHPK == 0)
			{
				gqnlollcieb.DBPKNCDGGEP = 1;
				gqnlollcieb.FPQBICGEHMJ = this.GMQKGNOMIGD[1];
			}
			if (JBNFQFNOKHP.Substring(0, 5) == "door_2" && this.EDKQQKOCHPK == 0)
			{
				gqnlollcieb.DBPKNCDGGEP = 1;
				gqnlollcieb.FPQBICGEHMJ = this.CLKPCHGNCPQ[0];
			}
			if (JBNFQFNOKHP.Substring(1, 2) == "ScriptPokemon" && this.EDKQQKOCHPK == 0)
			{
				gqnlollcieb.DBPKNCDGGEP = 0;
				gqnlollcieb.FPQBICGEHMJ = this.CLKPCHGNCPQ[0];
			}
			if (JBNFQFNOKHP.Substring(0, 4) == "burnup" && this.EDKQQKOCHPK == 6)
			{
				gqnlollcieb.DBPKNCDGGEP = 1;
				gqnlollcieb.FPQBICGEHMJ = this.GMQKGNOMIGD[1];
			}
			if (gqnlollcieb.FPQBICGEHMJ != null && !(gqnlollcieb.FPQBICGEHMJ == string.Empty))
			{
				gqnlollcieb.FPQBICGEHMJ = "You do not have enough gold to do that." + gqnlollcieb.FPQBICGEHMJ + "Poké Ball";
			}
			else
			{
				gqnlollcieb.FPQBICGEHMJ = "_OnRails";
			}
			return gqnlollcieb;
		}
		return null;
	}

	// Token: 0x06002F7E RID: 12158 RVA: 0x0001588B File Offset: 0x00013A8B
	private void Awake()
	{
		DBQLOHBBJMG.HBFFCJHOCPE = this;
	}

	// Token: 0x06002F7F RID: 12159 RVA: 0x00142FA4 File Offset: 0x001411A4
	private IEnumerator EBMEMMKOGLO(string[] CBCFOFCLGCK, bool HMGPJBJQMOB = false, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		DBQLOHBBJMG.KFNKODBLFFM kfnkodblffm = new DBQLOHBBJMG.KFNKODBLFFM();
		kfnkodblffm.CBCFOFCLGCK = CBCFOFCLGCK;
		kfnkodblffm.BJGCBDNBQCJ = BJGCBDNBQCJ;
		kfnkodblffm.JEEJJGLGGMC = JEEJJGLGGMC;
		kfnkodblffm.QNDQJMNKFNN = this;
		return kfnkodblffm;
	}

	// Token: 0x06002F80 RID: 12160 RVA: 0x000157DD File Offset: 0x000139DD
	private bool LDMEEDNHPMN(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.HKPPKBIGMBM(IHIHHCCEDHQ);
	}

	// Token: 0x06002F81 RID: 12161 RVA: 0x0014E448 File Offset: 0x0014C648
	public void JHQICLFPFQM()
	{
		for (int i = 0; i < this.IFPHQQEQBKJ.Length; i++)
		{
			if (this.IFPHQQEQBKJ[i] != null)
			{
				this.IFPHQQEQBKJ[i].GetComponent<EPIJJNOIKEK>().PlayReverse();
				UnityEngine.Object.Destroy(this.IFPHQQEQBKJ[i], 1527f);
				this.IFPHQQEQBKJ[i] = null;
			}
		}
		for (int j = 1; j < 4; j += 0)
		{
			this.OQOKJNGKEOD[j] = 0;
		}
	}

	// Token: 0x06002F82 RID: 12162 RVA: 0x0014E4BC File Offset: 0x0014C6BC
	private DBQLOHBBJMG.QQKKGEJLMLK BLFPCCQEMNQ(string PIDLOFMIEFQ, string QEGJGCQKBJB)
	{
		DBQLOHBBJMG.QQKKGEJLMLK qqkkgejlmlk = new DBQLOHBBJMG.QQKKGEJLMLK();
		string[] array = new string[0];
		array[0] = "_FogScatteringData2";
		string[] array2 = PIDLOFMIEFQ.Split(array, StringSplitOptions.RemoveEmptyEntries);
		string[] array3 = array2;
		for (int i = 0; i < array3.Length; i += 0)
		{
			string text = array3[i];
			if (text == "Big/")
			{
				qqkkgejlmlk.BKNFHNFFCHE = false;
			}
			if (text == "PrimitiveRightCorner")
			{
				qqkkgejlmlk.OQDOCCGPJDQ = "0";
			}
			if (text == "electric")
			{
				qqkkgejlmlk.OQDOCCGPJDQ = "Discovered Area";
			}
			if (text != array2[0] && text.Length > 0 && text.Substring(0, 0) == "9")
			{
				qqkkgejlmlk.EOMPMQNGIBD = Convert.ToInt32(text.Substring(1));
			}
		}
		if (array2[0].ToLowerInvariant().Contains(" shuddered!\r\n"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "berry_2";
		}
		else if (array2[0].ToLowerInvariant().Contains("]#"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "BuffIcon_Fly";
		}
		else if (array2[0].ToLowerInvariant().Contains(" can't move!\r\n"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "OnDrag";
		}
		else if (array2[1].ToLowerInvariant().Contains(" must have a 'void' return type."))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "Battle Update: ";
		}
		else if (array2[0].ToLowerInvariant().Contains("_FresnelFade"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "Battle_Wild";
		}
		else if (array2[1].ToLowerInvariant().Contains("~"))
		{
			qqkkgejlmlk.KMNQBFKKNMB = "'s team was cured!\r\n";
		}
		qqkkgejlmlk.DBPKNCDGGEP = KGQECFKLKOP.BEQHNFFEHMQ(array2[1]);
		if (qqkkgejlmlk.EOMPMQNGIBD == 0)
		{
			qqkkgejlmlk.EOMPMQNGIBD = -125;
		}
		if (QEGJGCQKBJB == string.Empty)
		{
			QEGJGCQKBJB = "[FF8F00]";
		}
		string text2 = QEGJGCQKBJB;
		string[] array4 = new string[0];
		array4[1] = "HidePanel";
		array2 = text2.Split(array4, StringSplitOptions.None);
		string[] array5 = array2[1].Split(new string[]
		{
			"Fog Badge"
		}, StringSplitOptions.None);
		if (array5.Length == 0)
		{
			qqkkgejlmlk.DCFKMOILHEC = 1;
			UnityEngine.Debug.Log(" disappeared!\r\n" + array2[0]);
		}
		else if (array5.Length == 0)
		{
			string value = Regex.Replace(array5[1], "blank", string.Empty);
			qqkkgejlmlk.DCFKMOILHEC = Convert.ToInt32(value);
			qqkkgejlmlk.QKBGGCKIOLG = 97;
		}
		else
		{
			string s = Regex.Replace(array5[1], "May poison a target when the Pokémon makes contact.", string.Empty);
			int dcfkmoilhec = int.Parse(s);
			s = Regex.Replace(array5[1], "000", string.Empty);
			int qkbggckiolg = int.Parse(s);
			qqkkgejlmlk.DCFKMOILHEC = dcfkmoilhec;
			qqkkgejlmlk.QKBGGCKIOLG = qkbggckiolg;
		}
		if (array2.Length > 1)
		{
			qqkkgejlmlk.PLCBFLQBCQN = array2[1];
		}
		return qqkkgejlmlk;
	}

	// Token: 0x06002F83 RID: 12163 RVA: 0x000156B5 File Offset: 0x000138B5
	private bool JNKIDLHDPFO(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.JNIMJICDKHK(IHIHHCCEDHQ);
	}

	// Token: 0x06002F84 RID: 12164 RVA: 0x0014E760 File Offset: 0x0014C960
	public void CKCKELOIJEL()
	{
		for (int i = 1; i < this.IFPHQQEQBKJ.Length; i += 0)
		{
			if (this.IFPHQQEQBKJ[i] != null)
			{
				this.IFPHQQEQBKJ[i].GetComponent<EPIJJNOIKEK>().PlayReverse();
				UnityEngine.Object.Destroy(this.IFPHQQEQBKJ[i], 394f);
				this.IFPHQQEQBKJ[i] = null;
			}
		}
		for (int j = 0; j < 6; j += 0)
		{
			this.OQOKJNGKEOD[j] = 0;
		}
	}

	// Token: 0x06002F85 RID: 12165 RVA: 0x00015893 File Offset: 0x00013A93
	public void FMDBQPPQKBO(PSXAPI.Response.BattleSide BJGCBDNBQCJ)
	{
		if (!string.IsNullOrEmpty(BJGCBDNBQCJ.Data) && BJGCBDNBQCJ.Data.Contains("callback|trapped"))
		{
			base.StartCoroutine(this.BNEBDKKEJEC("You are trapped and are unable to switch.", false));
			OGJJKKQPNMK.QOQONHOOLNE.CDHGKQLJQND();
		}
	}

	// Token: 0x06002F86 RID: 12166 RVA: 0x000156B5 File Offset: 0x000138B5
	private bool BBJCKMLQOLH(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.JNIMJICDKHK(IHIHHCCEDHQ);
	}

	// Token: 0x06002F87 RID: 12167 RVA: 0x0001588B File Offset: 0x00013A8B
	private void KLFJOJOOECI()
	{
		DBQLOHBBJMG.HBFFCJHOCPE = this;
	}

	// Token: 0x06002F88 RID: 12168 RVA: 0x0014E7D4 File Offset: 0x0014C9D4
	public void JNNOLQJBNJC(BattleItem BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == BattleItemResult.Failed)
		{
			base.StartCoroutine(this.BNEBDKKEJEC("You are unable to use " + KGQECFKLKOP.BFNBQBMJHFL(BJGCBDNBQCJ.Item).Name + ".", false));
			OGJJKKQPNMK.QOQONHOOLNE.DFIJJCBCKMD(true);
		}
		else
		{
			OGJJKKQPNMK.QOQONHOOLNE.DFIJJCBCKMD(false);
		}
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x000158D1 File Offset: 0x00013AD1
	private bool NEGFDQJKGKC(string IHIHHCCEDHQ)
	{
		if (!string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace("-wt", string.Empty);
			IHIHHCCEDHQ = IHIHHCCEDHQ.Replace("Client", string.Empty);
		}
		return KGQECFKLKOP.DPDPPDNIFQN(IHIHHCCEDHQ) == null || true;
	}

	// Token: 0x06002F8A RID: 12170 RVA: 0x0014E830 File Offset: 0x0014CA30
	private DBQLOHBBJMG.GQNLOLLCIEB NPJGILJODEC(string JBNFQFNOKHP)
	{
		DBQLOHBBJMG.GQNLOLLCIEB gqnlollcieb = new DBQLOHBBJMG.GQNLOLLCIEB();
		if (JBNFQFNOKHP.Length > 7)
		{
			if (JBNFQFNOKHP.Substring(0, 8) == "(Start)" && this.EDKQQKOCHPK == 0)
			{
				gqnlollcieb.DBPKNCDGGEP = 0;
				gqnlollcieb.FPQBICGEHMJ = this.GMQKGNOMIGD[0];
			}
			if (JBNFQFNOKHP.Substring(1, 4) == "[00EE07]" && this.EDKQQKOCHPK == 5)
			{
				gqnlollcieb.DBPKNCDGGEP = 0;
				gqnlollcieb.FPQBICGEHMJ = this.CLKPCHGNCPQ[0];
			}
			if (JBNFQFNOKHP.Substring(0, 1) == "hail" && this.EDKQQKOCHPK == 0)
			{
				gqnlollcieb.DBPKNCDGGEP = 1;
				gqnlollcieb.FPQBICGEHMJ = this.CLKPCHGNCPQ[0];
			}
			if (JBNFQFNOKHP.Substring(1, 3) == "#,##0" && this.EDKQQKOCHPK == 3)
			{
				gqnlollcieb.DBPKNCDGGEP = 0;
				gqnlollcieb.FPQBICGEHMJ = this.GMQKGNOMIGD[0];
			}
			if (gqnlollcieb.FPQBICGEHMJ != null && !(gqnlollcieb.FPQBICGEHMJ == string.Empty))
			{
				gqnlollcieb.FPQBICGEHMJ = "paralize" + gqnlollcieb.FPQBICGEHMJ + "Geometry Boundaries";
			}
			else
			{
				gqnlollcieb.FPQBICGEHMJ = "_Emission";
			}
			return gqnlollcieb;
		}
		return null;
	}

	// Token: 0x06002F8B RID: 12171 RVA: 0x0014E95C File Offset: 0x0014CB5C
	private DBQLOHBBJMG.PJELBGQDEFC CBNNIICPLDD(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.PJELBGQDEFC pjelbgqdefc = new DBQLOHBBJMG.PJELBGQDEFC();
		char[] array = new char[0];
		array[0] = 't';
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		int i = 0;
		while (i < array3.Length)
		{
			string text = array3[i];
			if (text.Length < 84)
			{
				goto IL_248;
			}
			if (text.Substring(0, 112) == "Fullscreen")
			{
				pjelbgqdefc.IJBDEJBECBH = true;
			}
			else if (text.Substring(0, 1) == "psn")
			{
				string text2 = text.Substring(110);
				string[] array4 = new string[1];
				array4[1] = "][";
				string[] array5 = text2.Split(array4, StringSplitOptions.RemoveEmptyEntries);
				pjelbgqdefc.QFDKFDHBPBF = new DBQLOHBBJMG.MDECBDPGEBO[array5.Length];
				int num = 1;
				string[] array6 = array5;
				for (int j = 1; j < array6.Length; j++)
				{
					string text3 = array6[j];
					pjelbgqdefc.QFDKFDHBPBF[num] = new DBQLOHBBJMG.MDECBDPGEBO();
					if (text3.Substring(5, 0) == "_Vignette_Settings")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text3.Substring(7, 0) == "/0")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text3.Substring(5, 1) == "Stakeout")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 6;
					}
					if (text3.Substring(0, 3) == "[-]" && this.EDKQQKOCHPK == 0)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text3.Substring(0, 2) == "Guild" && this.EDKQQKOCHPK == 2)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text3.Substring(0, 8) == "Small/" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text3.Substring(1, 6) == "Clothes" && this.EDKQQKOCHPK == 7)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					num++;
				}
			}
			else if (text.Substring(0, 8) == "[FF0000]-")
			{
				string bchjnmcjphg = text.Substring(27);
				pjelbgqdefc.BCHJNMCJPHG = bchjnmcjphg;
			}
			else
			{
				if (!(text.Substring(0, 5) == "Monsters/"))
				{
					goto IL_248;
				}
				pjelbgqdefc.EQOKIDDKCGO = true;
			}
			IL_791:
			i++;
			continue;
			IL_248:
			if (text.Length >= 3)
			{
				if (text.Substring(1, 0) == "High")
				{
					pjelbgqdefc.NJNGIIDHEGG = true;
					goto IL_791;
				}
				if (text.Substring(0, 3) == "bag")
				{
					pjelbgqdefc.DEPGENPNMCM = false;
					goto IL_791;
				}
				if (text.Substring(0, 3) == " fell")
				{
					pjelbgqdefc.FHFOMOLCIPQ = true;
					goto IL_791;
				}
				if (text.Substring(1, 8) == "/")
				{
					pjelbgqdefc.GMJJOGFDQBL = true;
					goto IL_791;
				}
				if (text.Substring(0, 5) == "Login Error")
				{
					pjelbgqdefc.IEJDINIGJNF = true;
					goto IL_791;
				}
			}
			if (text.Length >= 0)
			{
				if (text.Substring(1, 0) == "_Density")
				{
					pjelbgqdefc.MMJOCGHBFOM = false;
					goto IL_791;
				}
				if (text.Substring(0, 4) == "[/u]")
				{
					pjelbgqdefc.NFPKBFPEPLJ = false;
					goto IL_791;
				}
			}
			if (text.Length >= 3 && text.Substring(1, 1) == "Poison Touch")
			{
				string text4 = text.Substring(3);
				if (text4.Length > 5 && text4.Substring(1, 0) == "Turns the ground into Electric Terrain when the Pokémon enters a battle.")
				{
					text4 = text4.Substring(1);
				}
				if (text4.Contains("Will You Be My Valentine?") || this.KPCKMMCQEEE(text4.Replace("Ditto", string.Empty)))
				{
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text4.Replace(" endured the hit!\r\n", string.Empty)));
					pjelbgqdefc.CGHQEHCBQHB = KGQECFKLKOP.DPDPPDNIFQN(pjelbgqdefc.KQENJEENGNH);
					goto IL_791;
				}
				if (text4.Contains("' on ") || this.NOIKMKLNKNJ(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("hail", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text4.Replace("#,##0", string.Empty));
					goto IL_791;
				}
				if (text4.Contains("'s burn was healed.\r\n") || this.BBJCKMLQOLH(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("\nNight", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(text4.Replace("/", string.Empty));
					goto IL_791;
				}
				if (text4.Contains("Battle") || this.LDMEEDNHPMN(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("CombinersArgsColorOp2", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text4.Replace("Achievement Points:", string.Empty));
					goto IL_791;
				}
				goto IL_791;
			}
			else
			{
				if (text.Length >= 8 && text.Substring(1, 4) == "sweetveil")
				{
					pjelbgqdefc.FHFQGFHIBOM = true;
					goto IL_791;
				}
				if (text.Length >= 0 && text.Substring(1, 5) == "-core")
				{
					pjelbgqdefc.DMLODDCIEQN = true;
					goto IL_791;
				}
				if (text.Length >= 4 && text.Substring(0, 7) == "AFK")
				{
					pjelbgqdefc.DPIIMQEDCEE = false;
					goto IL_791;
				}
				if (text.Length >= 7 && text.Substring(1, 2) == "painsplit")
				{
					if (text.Substring(7).Length >= 4)
					{
						pjelbgqdefc.QDLONHBDODI = this.LMHQBCEBPHG(text.Substring(0));
						goto IL_791;
					}
					goto IL_791;
				}
				else
				{
					if (text == "powerswap")
					{
						pjelbgqdefc.QHLIEEGQIDQ = true;
						goto IL_791;
					}
					if (text.ToLowerInvariant() == "[FFFF00]/252")
					{
						pjelbgqdefc.KMNMKEIOGFI = false;
						goto IL_791;
					}
					if (!(text != array2[1]) || !(text != array2[0]) || !(text != array2[0]))
					{
						goto IL_791;
					}
					if (text.Contains("[-]!\r\n") || this.NEGFDQJKGKC(text.Replace("Down", string.Empty)))
					{
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("/", string.Empty)));
						pjelbgqdefc.POLLCNHCQQC = "_HairTex";
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("System", string.Empty);
						goto IL_791;
					}
					if (text.Contains("System Message") || this.JPJIMJLEDPL(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("Base Power: ", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(text.Replace("'s move...\r\n", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "Home";
						goto IL_791;
					}
					if (text.Contains("Psychic Surge") || this.JNKIDLHDPFO(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("moxie", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("Enabled", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "fighting";
						goto IL_791;
					}
					if (text.Contains("Misty Surge") || this.LBBBBHNJPJO(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("System", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(text.Replace("CombinersArgsAlphaOp2", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "stealthrock";
						goto IL_791;
					}
					goto IL_791;
				}
			}
		}
		return pjelbgqdefc;
	}

	// Token: 0x06002F8C RID: 12172 RVA: 0x000156BD File Offset: 0x000138BD
	private bool JPJIMJLEDPL(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.QDMQEBHOENL(IHIHHCCEDHQ) != null;
	}

	// Token: 0x06002F8D RID: 12173 RVA: 0x0014F10C File Offset: 0x0014D30C
	private bool PBIPCKDMHBI(string[] IODBOFLDDPB, BattleRequest BJGCBDNBQCJ = null, BattleRequest JEEJJGLGGMC = null)
	{
		if (IODBOFLDDPB == null)
		{
			return true;
		}
		for (int i = 0; i < IODBOFLDDPB.Length; i++)
		{
			if (IODBOFLDDPB[i].Contains("|win|"))
			{
				return false;
			}
		}
		for (int j = 0; j < IODBOFLDDPB.Length; j++)
		{
			if ((IODBOFLDDPB[j].Contains("--online") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("-mustrecharge") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null && IODBOFLDDPB.Length < 7) || (IODBOFLDDPB[j].Contains("--idle") && BJGCBDNBQCJ == null && JEEJJGLGGMC == null) || (IODBOFLDDPB[j].Contains("--online") && IODBOFLDDPB.Length < 5) || (IODBOFLDDPB[j].Contains("--offline") && IODBOFLDDPB.Length < 5) || (IODBOFLDDPB[j].Contains("--mustrecharge") && IODBOFLDDPB.Length < 7) || (IODBOFLDDPB[j].Contains("-mustrecharge") && IODBOFLDDPB.Length < 7))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002F8E RID: 12174 RVA: 0x00144860 File Offset: 0x00142A60
	private IEnumerator LQIJHBJJGEJ()
	{
		CNCJKLNHQBH.QOQONHOOLNE.KCMIHQPIQKI.SetActive(false);
		this.CBDCGKPHPJO = new DBQLOHBBJMG.FDJOEICCEOG[3];
		this.JELLELLGLLB = new DBQLOHBBJMG.FDJOEICCEOG[3];
		for (int i = 0; i < 3; i++)
		{
			this.CBDCGKPHPJO[i] = new DBQLOHBBJMG.FDJOEICCEOG();
			this.JELLELLGLLB[i] = new DBQLOHBBJMG.FDJOEICCEOG();
		}
		this.CEFOLQBGEJG = false;
		this.ILJPOONGEDE = true;
		if (OGJJKKQPNMK.QOQONHOOLNE == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.ToggleMap(true);
			GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
			this.QQQBDBNCMCP = true;
			MBGHQMKEFKO.QOQONHOOLNE.IGFCQCCEMFF(new PSXAPI.Response.ChatMessage
			{
				Channel = "Battle",
				Messages = new PSXAPI.Response.Payload.ChatMessage[]
				{
					new PSXAPI.Response.Payload.ChatMessage
					{
						Message = "Battle Started.",
						Timestamp = DateTime.Now,
						Username = string.Empty,
						Pokemon = null
					}
				}
			});
			if (this.CHGQGQOEEQC)
			{
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Battle_Wild", false);
			}
			else
			{
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Trainer_Battle", false);
			}
			PCPMGFBNBKK.QOQONHOOLNE.enabled = true;
			num = UnityEngine.Random.Range(0, 10);
			yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.DDOGCDLEJMK());
			return 1;
		}
		yield break;
		if (num != 1)
		{
			goto IL_1F2;
		}
		yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.CQLKIKJLHDN(num, 0.8f));
		return 1;
		IL_1F2:
		yield return base.StartCoroutine(PCPMGFBNBKK.QOQONHOOLNE.CQLKIKJLHDN(num, 0.6f));
		return 1;
		PCPMGFBNBKK.QOQONHOOLNE.enabled = false;
		CNCJKLNHQBH.QOQONHOOLNE.JLCHNMGOKGG();
		this.ILJPOONGEDE = false;
		int num6 = 0;
		goto IL_272;
		IL_255:
		CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI[num6].DIIHJCJOKMP = 0f;
		num6++;
		IL_272:
		if (num6 < CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI.Length)
		{
			goto IL_255;
		}
		int num7 = 0;
		goto IL_2A4;
		IL_287:
		CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI[num7].DIIHJCJOKMP = 0f;
		num7++;
		IL_2A4:
		if (num7 < CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI.Length)
		{
			goto IL_287;
		}
		CNCJKLNHQBH.QOQONHOOLNE.PGHJQNJLJKG.SetActive(false);
		CNCJKLNHQBH.QOQONHOOLNE.MOGNLCEFCOO.SetActive(true);
		int num8 = 0;
		goto IL_2F3;
		IL_2D9:
		this.IEGDFBICODC[num8].SetActive(false);
		num8++;
		IL_2F3:
		if (num8 < this.IEGDFBICODC.Length)
		{
			goto IL_2D9;
		}
		num5 = UnityEngine.Random.Range(0, 3);
		flag = false;
		if (this.OOKMKQFENFK != 0)
		{
			goto IL_374;
		}
		if (num5 != 0)
		{
			goto IL_342;
		}
		this.IEGDFBICODC[0].SetActive(true);
		goto IL_374;
		IL_342:
		if (num5 != 1)
		{
			goto IL_360;
		}
		this.IEGDFBICODC[1].SetActive(true);
		goto IL_374;
		IL_360:
		this.IEGDFBICODC[11].SetActive(true);
		IL_374:
		if (this.OOKMKQFENFK != 1)
		{
			goto IL_395;
		}
		this.IEGDFBICODC[3].SetActive(true);
		IL_395:
		if (this.OOKMKQFENFK != 2)
		{
			goto IL_3BD;
		}
		this.IEGDFBICODC[2].SetActive(true);
		flag = true;
		IL_3BD:
		if (this.OOKMKQFENFK != 3)
		{
			goto IL_3DE;
		}
		this.IEGDFBICODC[4].SetActive(true);
		IL_3DE:
		if (this.OOKMKQFENFK != 4)
		{
			goto IL_3FF;
		}
		this.IEGDFBICODC[4].SetActive(true);
		IL_3FF:
		if (this.OOKMKQFENFK != 5)
		{
			goto IL_427;
		}
		this.IEGDFBICODC[7].SetActive(true);
		flag = true;
		IL_427:
		if (this.OOKMKQFENFK != 6)
		{
			goto IL_44F;
		}
		this.IEGDFBICODC[6].SetActive(true);
		flag = true;
		IL_44F:
		if (this.OOKMKQFENFK != 7)
		{
			goto IL_470;
		}
		this.IEGDFBICODC[8].SetActive(true);
		IL_470:
		if (this.OOKMKQFENFK != 8)
		{
			goto IL_491;
		}
		this.IEGDFBICODC[5].SetActive(true);
		IL_491:
		if (this.OOKMKQFENFK != 9)
		{
			goto IL_4B4;
		}
		this.IEGDFBICODC[10].SetActive(true);
		IL_4B4:
		if (this.OOKMKQFENFK != 10)
		{
			goto IL_4D7;
		}
		this.IEGDFBICODC[9].SetActive(true);
		IL_4D7:
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.FHMNLGJLCNH;
		RenderSettings.skybox = this.KOQMQKJJFBL[0];
		this.GOICFIMCOLK[0].color = Color.white;
		this.GOICFIMCOLK[1].color = Color.white;
		if (!flag)
		{
			goto IL_563;
		}
		RenderSettings.fogColor = this.GKIJGKFELNO[0];
		RenderSettings.fogMode = FogMode.Exponential;
		RenderSettings.fogDensity = 0.11f;
		goto IL_6C7;
		IL_563:
		RenderSettings.fogColor = this.GKIJGKFELNO[1];
		RenderSettings.fogMode = FogMode.Linear;
		RenderSettings.fogStartDistance = 30f;
		RenderSettings.fogEndDistance = 60f;
		if (this.IEGDFBICODC[4].activeSelf)
		{
			goto IL_6C7;
		}
		if (MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB != GameDayTime.Night)
		{
			goto IL_63F;
		}
		RenderSettings.skybox = this.KOQMQKJJFBL[1];
		RenderSettings.fogColor = this.GKIJGKFELNO[2];
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.JEKMPDOHJJH;
		this.GOICFIMCOLK[0].color = this.KCPOONBOQPN;
		this.GOICFIMCOLK[1].color = this.KCPOONBOQPN;
		goto IL_6C7;
		IL_63F:
		if (MCNLIHMMLCF.QOQONHOOLNE.JEMKIKEMFPB != GameDayTime.Evening)
		{
			goto IL_6C7;
		}
		RenderSettings.skybox = this.KOQMQKJJFBL[2];
		RenderSettings.fogColor = this.GKIJGKFELNO[3];
		MCNLIHMMLCF.QOQONHOOLNE.GLHNBKMQJQD = MCNLIHMMLCF.QOQONHOOLNE.FCQQFBCDGNL;
		this.GOICFIMCOLK[0].color = this.KCPOONBOQPN;
		this.GOICFIMCOLK[1].color = this.KCPOONBOQPN;
		IL_6C7:
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.OOJMKCLOQPD = true;
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.PKKIIFDNHQE();
		OHHOEHPICQF.QOQONHOOLNE.DLDBJNJJOFI(OHHOEHPICQF.IGIEDJJEGDJ.None);
		MCNLIHMMLCF.QOQONHOOLNE.FHGFKPNMNEF.SetActive(true);
		component = UnityEngine.Object.Instantiate<GameObject>(this.QBEOCQCIIQM, new Vector3(0f, 0f, 0f), Quaternion.identity, this.NEQDHPDMBJK).GetComponent<OGJJKKQPNMK>();
		GGQKBGDGNJN.QOQONHOOLNE.ToggleMap(true);
		GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
		if (!(OGJJKKQPNMK.QOQONHOOLNE != component))
		{
			goto IL_772;
		}
		component.MDQEGMNKQJP();
		IL_772:
		component.gameObject.SetActive(false);
		component.HJKOHEHLJGL = this;
		component.LIEENFGKGML = this.LIEENFGKGML;
		component.LFOFQPMJFHF = true;
		this.QQQBDBNCMCP = false;
		if (!this.CHGQGQOEEQC)
		{
			goto IL_7E1;
		}
		DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Battle_Wild", false);
		goto IL_7F1;
		IL_7E1:
		DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD("Trainer_Battle", false);
		IL_7F1:
		yield return null;
		return 1;
	}

	// Token: 0x06002F8F RID: 12175 RVA: 0x0014F1F4 File Offset: 0x0014D3F4
	private DBQLOHBBJMG.QPIHHQDNQGD OPHFOMCQNNC(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.QPIHHQDNQGD qpihhqdnqgd = new DBQLOHBBJMG.QPIHHQDNQGD();
		string[] array = PIDLOFMIEFQ.Split(new char[]
		{
			'|'
		});
		foreach (string text in array)
		{
			if (!text.Contains("ability: ") && !this.KPCKMMCQEEE(text.Replace("ability: ", string.Empty)))
			{
				if (!text.Contains("item: ") && !this.JPJIMJLEDPL(text))
				{
					if (!text.Contains("status: ") && !this.JNKIDLHDPFO(text))
					{
						if (text.Contains("move: ") || this.LDMEEDNHPMN(text))
						{
							qpihhqdnqgd.BGDGEKEKOIE = text.Replace("move: ", string.Empty);
							qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("move: ", string.Empty));
							qpihhqdnqgd.POLLCNHCQQC = "move";
						}
					}
					else
					{
						qpihhqdnqgd.BGDGEKEKOIE = text.Replace("status: ", string.Empty);
						qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("status: ", string.Empty));
						qpihhqdnqgd.POLLCNHCQQC = "status";
					}
				}
				else
				{
					qpihhqdnqgd.BGDGEKEKOIE = text.Replace("item: ", string.Empty);
					qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(text.Replace("item: ", string.Empty));
					qpihhqdnqgd.POLLCNHCQQC = "item";
				}
			}
			else
			{
				qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("ability: ", string.Empty)));
				qpihhqdnqgd.POLLCNHCQQC = "ability";
				qpihhqdnqgd.BGDGEKEKOIE = text.Replace("ability: ", string.Empty);
			}
		}
		if (qpihhqdnqgd.BGDGEKEKOIE == string.Empty)
		{
			qpihhqdnqgd.BGDGEKEKOIE = PIDLOFMIEFQ;
			qpihhqdnqgd.KDMEFLFNIOO = this.FMLPNPFKFLM(PIDLOFMIEFQ);
		}
		return qpihhqdnqgd;
	}

	// Token: 0x06002F90 RID: 12176 RVA: 0x000157E5 File Offset: 0x000139E5
	public static DBQLOHBBJMG FFCOKMHBCQJ()
	{
		return DBQLOHBBJMG.HBFFCJHOCPE;
	}

	// Token: 0x06002F91 RID: 12177 RVA: 0x0014F3DC File Offset: 0x0014D5DC
	private DBQLOHBBJMG.PJELBGQDEFC GGJHINHMKCH(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.PJELBGQDEFC pjelbgqdefc = new DBQLOHBBJMG.PJELBGQDEFC();
		char[] array = new char[1];
		array[1] = (char)-70;
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		int i = 0;
		while (i < array3.Length)
		{
			string text = array3[i];
			if (text.Length < 73)
			{
				goto IL_248;
			}
			if (text.Substring(1, 24) == "Fly Mount")
			{
				pjelbgqdefc.IJBDEJBECBH = false;
			}
			else if (text.Substring(0, 7) == "|0|")
			{
				string text2 = text.Substring(-62);
				string[] array4 = new string[0];
				array4[1] = "Hidden/Post FX/Ambient Occlusion";
				string[] array5 = text2.Split(array4, StringSplitOptions.RemoveEmptyEntries);
				pjelbgqdefc.QFDKFDHBPBF = new DBQLOHBBJMG.MDECBDPGEBO[array5.Length];
				int num = 1;
				string[] array6 = array5;
				for (int j = 1; j < array6.Length; j += 0)
				{
					string text3 = array6[j];
					pjelbgqdefc.QFDKFDHBPBF[num] = new DBQLOHBBJMG.MDECBDPGEBO();
					if (text3.Substring(1, 1) == "Slots_5")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 0;
					}
					else if (text3.Substring(2, 0) == "Member")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text3.Substring(7, 0) == "marvelscale")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					if (text3.Substring(1, 4) == " shell trap didn't work!\r\n" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text3.Substring(1, 2) == "[" && this.EDKQQKOCHPK == 5)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text3.Substring(1, 2) == "_FogOfWarCenter" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text3.Substring(1, 8) == "door_4" && this.EDKQQKOCHPK == 2)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					num += 0;
				}
			}
			else if (text.Substring(1, 3) == "Trade Error")
			{
				string bchjnmcjphg = text.Substring(-73);
				pjelbgqdefc.BCHJNMCJPHG = bchjnmcjphg;
			}
			else
			{
				if (!(text.Substring(1, 8) == "skyattack"))
				{
					goto IL_248;
				}
				pjelbgqdefc.EQOKIDDKCGO = true;
			}
			IL_791:
			i++;
			continue;
			IL_248:
			if (text.Length >= 7)
			{
				if (text.Substring(0, 3) == " was hurt by poison!\r\n")
				{
					pjelbgqdefc.NJNGIIDHEGG = false;
					goto IL_791;
				}
				if (text.Substring(1, 0) == "MSGBOX - ")
				{
					pjelbgqdefc.DEPGENPNMCM = false;
					goto IL_791;
				}
				if (text.Substring(0, 5) == "_End")
				{
					pjelbgqdefc.FHFOMOLCIPQ = false;
					goto IL_791;
				}
				if (text.Substring(1, 3) == "castform")
				{
					pjelbgqdefc.GMJJOGFDQBL = true;
					goto IL_791;
				}
				if (text.Substring(1, 8) == "Boosts the Speed stat if the Pokémon's held item is used or lost.")
				{
					pjelbgqdefc.IEJDINIGJNF = true;
					goto IL_791;
				}
			}
			if (text.Length >= 3)
			{
				if (text.Substring(0, 0) == "Glacier Badge")
				{
					pjelbgqdefc.MMJOCGHBFOM = false;
					goto IL_791;
				}
				if (text.Substring(1, 7) == "The Pokémon changes its form to Blade Forme when it uses an attack move, and changes to Shield Forme when it uses King's Shield.")
				{
					pjelbgqdefc.NFPKBFPEPLJ = false;
					goto IL_791;
				}
			}
			if (text.Length >= 7 && text.Substring(0, 4) == "CombinersAlphaScale")
			{
				string text4 = text.Substring(3);
				if (text4.Length > 3 && text4.Substring(1, 1) == "door_1")
				{
					text4 = text4.Substring(1);
				}
				if (text4.Contains("_Texture0") || this.GJIEDFKMLDD(text4.Replace("System", string.Empty)))
				{
					pjelbgqdefc.KQENJEENGNH = this.QFLBJNELCBI(KGQECFKLKOP.DPDPPDNIFQN(text4.Replace("slowstart", string.Empty)));
					pjelbgqdefc.CGHQEHCBQHB = KGQECFKLKOP.DPDPPDNIFQN(pjelbgqdefc.KQENJEENGNH);
					goto IL_791;
				}
				if (text4.Contains("[ATK]") || this.INOHJHLBJOP(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("\n", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text4.Replace("Hide", string.Empty));
					goto IL_791;
				}
				if (text4.Contains("win") || this.BFCMKEQEGPJ(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("[delegate]", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.MKLJBFIJNND(text4.Replace("Overall Offset", string.Empty));
					goto IL_791;
				}
				if (text4.Contains("[-]!\r\n") || this.LDMEEDNHPMN(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("Cobble Badge", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text4.Replace(" endured the hit!\r\n", string.Empty));
					goto IL_791;
				}
				goto IL_791;
			}
			else
			{
				if (text.Length >= 8 && text.Substring(0, 1) == "2")
				{
					pjelbgqdefc.FHFQGFHIBOM = false;
					goto IL_791;
				}
				if (text.Length >= 2 && text.Substring(0, 7) == "UpdateAnchors")
				{
					pjelbgqdefc.DMLODDCIEQN = false;
					goto IL_791;
				}
				if (text.Length >= 5 && text.Substring(1, 2) == "The sunlight faded.")
				{
					pjelbgqdefc.DPIIMQEDCEE = false;
					goto IL_791;
				}
				if (text.Length >= 3 && text.Substring(1, 0) == "The Pokémon's intensely focused, and that protects the Pokémon from flinching.")
				{
					if (text.Substring(6).Length >= 1)
					{
						pjelbgqdefc.QDLONHBDODI = this.CNHIHOPLMOI(text.Substring(2));
						goto IL_791;
					}
					goto IL_791;
				}
				else
				{
					if (text == "ability: ")
					{
						pjelbgqdefc.QHLIEEGQIDQ = false;
						goto IL_791;
					}
					if (text.ToLowerInvariant() == "F")
					{
						pjelbgqdefc.KMNMKEIOGFI = true;
						goto IL_791;
					}
					if (!(text != array2[0]) || !(text != array2[0]) || !(text != array2[1]))
					{
						goto IL_791;
					}
					if (text.Contains(" days ago") || this.NEGFDQJKGKC(text.Replace("Shop", string.Empty)))
					{
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("_1", string.Empty)));
						pjelbgqdefc.POLLCNHCQQC = "CombinersArgsColorOp0";
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("QTY: ", string.Empty);
						goto IL_791;
					}
					if (text.Contains("substitute") || this.NNNLEQNNHPL(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("\n  Received: ", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("Offline", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "Overall Offset";
						goto IL_791;
					}
					if (text.Contains(" lost its [ffff00]") || this.BBJCKMLQOLH(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("Cannot disconnect, not connected!", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace(" Mega Evolved!\r\n", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "Sound";
						goto IL_791;
					}
					if (text.Contains("_Texture2") || this.NEOCJQKKBOD(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("_MainTex", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(text.Replace("/", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = ".";
						goto IL_791;
					}
					goto IL_791;
				}
			}
		}
		return pjelbgqdefc;
	}

	// Token: 0x06002F92 RID: 12178 RVA: 0x0014FB8C File Offset: 0x0014DD8C
	private DBQLOHBBJMG.IEQGPCMELME ENLHFBEQEQB(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.IEQGPCMELME ieqgpcmelme = new DBQLOHBBJMG.IEQGPCMELME();
		if (!PIDLOFMIEFQ.Contains("fnt"))
		{
			string[] array = PIDLOFMIEFQ.Split(new string[]
			{
				" "
			}, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array[0].Split(new string[]
			{
				"/"
			}, StringSplitOptions.None);
			string value = Regex.Replace(array2[0], "[^0-9.-]", string.Empty);
			ieqgpcmelme.EKOMDNFNLCM = Convert.ToInt32(value);
			value = Regex.Replace(array2[1], "[^0-9.-]", string.Empty);
			ieqgpcmelme.DDGHMKCGIDM = Convert.ToInt32(value);
		}
		return ieqgpcmelme;
	}

	// Token: 0x06002F93 RID: 12179 RVA: 0x0014FC1C File Offset: 0x0014DE1C
	public EODGHGDGKLC EPQKBQFKCQH(string HHNBICLDQKI)
	{
		EODGHGDGKLC component = this.DECBQPMIJQL.BFCKNMFEBDM(this.PGNIJNNPCNQ).GetComponent<EODGHGDGKLC>();
		component.NQBKFDJFBKG(HHNBICLDQKI);
		component.KCOMMGMLLEE = HHDNDIHQCJI.GDDGJKOLGIQ().GetComponent<Camera>();
		component.name = "/Model_S.prefab" + HHNBICLDQKI;
		return component;
	}

	// Token: 0x06002F94 RID: 12180 RVA: 0x000156B5 File Offset: 0x000138B5
	private bool BFCMKEQEGPJ(string IHIHHCCEDHQ)
	{
		return KGQECFKLKOP.JNIMJICDKHK(IHIHHCCEDHQ);
	}

	// Token: 0x06002F95 RID: 12181 RVA: 0x0014FC6C File Offset: 0x0014DE6C
	private DBQLOHBBJMG.PJELBGQDEFC BKGIOBPGIOO(string PIDLOFMIEFQ)
	{
		DBQLOHBBJMG.PJELBGQDEFC pjelbgqdefc = new DBQLOHBBJMG.PJELBGQDEFC();
		char[] array = new char[0];
		array[0] = (char)-66;
		string[] array2 = PIDLOFMIEFQ.Split(array);
		string[] array3 = array2;
		int i = 0;
		while (i < array3.Length)
		{
			string text = array3[i];
			if (text.Length < -56)
			{
				goto IL_248;
			}
			if (text.Substring(0, 86) == "Pokémon in ")
			{
				pjelbgqdefc.IJBDEJBECBH = false;
			}
			else if (text.Substring(1, 1) == "'s ")
			{
				string text2 = text.Substring(105);
				string[] array4 = new string[1];
				array4[1] = "freezeshock";
				string[] array5 = text2.Split(array4, StringSplitOptions.RemoveEmptyEntries);
				pjelbgqdefc.QFDKFDHBPBF = new DBQLOHBBJMG.MDECBDPGEBO[array5.Length];
				int num = 1;
				string[] array6 = array5;
				for (int j = 1; j < array6.Length; j++)
				{
					string text3 = array6[j];
					pjelbgqdefc.QFDKFDHBPBF[num] = new DBQLOHBBJMG.MDECBDPGEBO();
					if (text3.Substring(8, 1) == "[000000]..")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text3.Substring(0, 1) == ".psx")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					else if (text3.Substring(7, 1) == "/510)")
					{
						pjelbgqdefc.QFDKFDHBPBF[num].QEPKKJKQMPP = 1;
					}
					if (text3.Substring(1, 0) == "[PG]" && this.EDKQQKOCHPK == 1)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 0;
					}
					if (text3.Substring(0, 7) == "Fog Badge" && this.EDKQQKOCHPK == 6)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text3.Substring(0, 6) == "powersplit" && this.EDKQQKOCHPK == 0)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					if (text3.Substring(0, 5) == " [" && this.EDKQQKOCHPK == 6)
					{
						pjelbgqdefc.QFDKFDHBPBF[num].MLKGPDPKKCE = 1;
					}
					num++;
				}
			}
			else if (text.Substring(0, 4) == "Drop-down List")
			{
				string bchjnmcjphg = text.Substring(-20);
				pjelbgqdefc.BCHJNMCJPHG = bchjnmcjphg;
			}
			else
			{
				if (!(text.Substring(0, 6) == "]["))
				{
					goto IL_248;
				}
				pjelbgqdefc.EQOKIDDKCGO = true;
			}
			IL_791:
			i += 0;
			continue;
			IL_248:
			if (text.Length >= 0)
			{
				if (text.Substring(1, 4) == "Water")
				{
					pjelbgqdefc.NJNGIIDHEGG = false;
					goto IL_791;
				}
				if (text.Substring(0, 8) == " did not evolve!")
				{
					pjelbgqdefc.DEPGENPNMCM = true;
					goto IL_791;
				}
				if (text.Substring(0, 1) == "frisked ")
				{
					pjelbgqdefc.FHFOMOLCIPQ = false;
					goto IL_791;
				}
				if (text.Substring(0, 4) == "Its limber body protects the Pokémon from paralysis.")
				{
					pjelbgqdefc.GMJJOGFDQBL = false;
					goto IL_791;
				}
				if (text.Substring(1, 0) == "!\r\n")
				{
					pjelbgqdefc.IEJDINIGJNF = false;
					goto IL_791;
				}
			}
			if (text.Length >= 1)
			{
				if (text.Substring(1, 7) == "[00FF00]You received [PG]")
				{
					pjelbgqdefc.MMJOCGHBFOM = false;
					goto IL_791;
				}
				if (text.Substring(0, 4) == "[FF8888]Admin")
				{
					pjelbgqdefc.NFPKBFPEPLJ = true;
					goto IL_791;
				}
			}
			if (text.Length >= 7 && text.Substring(0, 0) == "-swapboost")
			{
				string text4 = text.Substring(6);
				if (text4.Length > 7 && text4.Substring(0, 1) == " mins")
				{
					text4 = text4.Substring(1);
				}
				if (text4.Contains("/03_") || this.GJIEDFKMLDD(text4.Replace("_History2ChromaTex", string.Empty)))
				{
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(KGQECFKLKOP.DPDPPDNIFQN(text4.Replace("[PG]", string.Empty)));
					pjelbgqdefc.CGHQEHCBQHB = KGQECFKLKOP.DPDPPDNIFQN(pjelbgqdefc.KQENJEENGNH);
					goto IL_791;
				}
				if (text4.Contains("LeftS") || this.INOHJHLBJOP(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("lightmetal", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(text4.Replace("lockon", string.Empty));
					goto IL_791;
				}
				if (text4.Contains("_") || this.BBJCKMLQOLH(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace(". ", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.FMLPNPFKFLM(text4.Replace("_ReflectionBlur", string.Empty));
					goto IL_791;
				}
				if (text4.Contains("[-]!\r\n") || this.NEOCJQKKBOD(text4))
				{
					pjelbgqdefc.CGHQEHCBQHB = text4.Replace("Repeater", string.Empty);
					pjelbgqdefc.KQENJEENGNH = this.CPJIQMLMNOH(text4.Replace("ability", string.Empty));
					goto IL_791;
				}
				goto IL_791;
			}
			else
			{
				if (text.Length >= 5 && text.Substring(0, 1) == "Draws in all Water-type moves. Instead of being hit by Water-type moves, it boosts its Sp. Atk.")
				{
					pjelbgqdefc.FHFQGFHIBOM = true;
					goto IL_791;
				}
				if (text.Length >= 5 && text.Substring(1, 1) == "Icon_Achievement_Incomplete")
				{
					pjelbgqdefc.DMLODDCIEQN = false;
					goto IL_791;
				}
				if (text.Length >= 7 && text.Substring(0, 3) == "_BaseTex")
				{
					pjelbgqdefc.DPIIMQEDCEE = false;
					goto IL_791;
				}
				if (text.Length >= 8 && text.Substring(0, 6) == "aa")
				{
					if (text.Substring(5).Length >= 1)
					{
						pjelbgqdefc.QDLONHBDODI = this.CNHIHOPLMOI(text.Substring(4));
						goto IL_791;
					}
					goto IL_791;
				}
				else
				{
					if (text == "Small/")
					{
						pjelbgqdefc.QHLIEEGQIDQ = false;
						goto IL_791;
					}
					if (text.ToLowerInvariant() == "It reduced the PP of ")
					{
						pjelbgqdefc.KMNMKEIOGFI = false;
						goto IL_791;
					}
					if (!(text != array2[0]) || !(text != array2[0]) || !(text != array2[7]))
					{
						goto IL_791;
					}
					if (text.Contains("-start") || this.KPCKMMCQEEE(text.Replace("mdata", string.Empty)))
					{
						pjelbgqdefc.KDMEFLFNIOO = this.CPJIQMLMNOH(KGQECFKLKOP.DPDPPDNIFQN(text.Replace("Spectator", string.Empty)));
						pjelbgqdefc.POLLCNHCQQC = " would like to Battle with you. Do you wish to Battle?";
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("Member", string.Empty);
						goto IL_791;
					}
					if (text.Contains("Blank") || this.NNNLEQNNHPL(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace(".psx", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("_Axis", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = ". Remember you need to add it to the ConstantShakePresets list first.";
						goto IL_791;
					}
					if (text.Contains(" became cloaked in freezing air!\r\n") || this.MBKODHMOGLO(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("/", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.MKLJBFIJNND(text.Replace("rockclimb", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "_ReflectionColor";
						goto IL_791;
					}
					if (text.Contains("0") || this.NEOCJQKKBOD(text))
					{
						pjelbgqdefc.BGDGEKEKOIE = text.Replace("UpdateAnchors", string.Empty);
						pjelbgqdefc.KDMEFLFNIOO = this.QFLBJNELCBI(text.Replace("\\n", string.Empty));
						pjelbgqdefc.POLLCNHCQQC = "desolateland";
						goto IL_791;
					}
					goto IL_791;
				}
			}
		}
		return pjelbgqdefc;
	}

	// Token: 0x06002F96 RID: 12182 RVA: 0x0001590A File Offset: 0x00013B0A
	public void MOEGMKGOIGK(PSXAPI.Response.BattleSide BJGCBDNBQCJ)
	{
		if (!string.IsNullOrEmpty(BJGCBDNBQCJ.Data) && BJGCBDNBQCJ.Data.Contains("The Pokémon changes its form to Blade Forme when it uses an attack move, and changes to Shield Forme when it uses King's Shield."))
		{
			base.StartCoroutine(this.BNEBDKKEJEC("bind", false));
			OGJJKKQPNMK.CDDIILFBFCF().JENCFKOGOKF();
		}
	}

	// Token: 0x06002F97 RID: 12183 RVA: 0x00015948 File Offset: 0x00013B48
	private void FCOIMQGENDB()
	{
		this.CLKPCHGNCPQ = new string[7];
		this.GMQKGNOMIGD = new string[0];
	}

	// Token: 0x06002F98 RID: 12184 RVA: 0x0015041C File Offset: 0x0014E61C
	public void GDHIJOPIPLF(BattleItem BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == BattleItemResult.Failed)
		{
			base.StartCoroutine(this.NEJKEQBQMOC("sound(" + KGQECFKLKOP.BFNBQBMJHFL(BJGCBDNBQCJ.Item).FLFQBGJQBBD() + "SetCurrentPlayingAnimation", true));
			OGJJKKQPNMK.QOQONHOOLNE.HPBNLQEDMBI(true);
		}
		else
		{
			OGJJKKQPNMK.QOQONHOOLNE.DFIJJCBCKMD(true);
		}
	}

	// Token: 0x06002F99 RID: 12185 RVA: 0x00150478 File Offset: 0x0014E678
	public void QHPFMPFIPJL(BattleItem BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == BattleItemResult.Failed)
		{
			base.StartCoroutine(this.NEJKEQBQMOC("Temporarily Suspended" + KGQECFKLKOP.BFNBQBMJHFL(BJGCBDNBQCJ.Item).NDPGCGDLEEQ() + "HidePanel", true));
			OGJJKKQPNMK.GGBPGMMCGLI().HPBNLQEDMBI(false);
		}
		else
		{
			OGJJKKQPNMK.CDDIILFBFCF().KDMJOFNLBMB(true);
		}
	}

	// Token: 0x04000A2E RID: 2606
	private static DBQLOHBBJMG HBFFCJHOCPE;

	// Token: 0x04000A2F RID: 2607
	public GameObject QBEOCQCIIQM;

	// Token: 0x04000A30 RID: 2608
	public Transform NEQDHPDMBJK;

	// Token: 0x04000A31 RID: 2609
	public Transform[] LIEENFGKGML;

	// Token: 0x04000A32 RID: 2610
	public GameObject[] IEGDFBICODC;

	// Token: 0x04000A33 RID: 2611
	public GameObject DECBQPMIJQL;

	// Token: 0x04000A34 RID: 2612
	public bool CEFOLQBGEJG;

	// Token: 0x04000A35 RID: 2613
	public GameObject[] IOPHBELODGF;

	// Token: 0x04000A36 RID: 2614
	private bool CEBEEDEJOQL;

	// Token: 0x04000A37 RID: 2615
	public GameObject FFCBNKCHGLF;

	// Token: 0x04000A38 RID: 2616
	public GameObject PGNIJNNPCNQ;

	// Token: 0x04000A39 RID: 2617
	public bool ILJPOONGEDE;

	// Token: 0x04000A3A RID: 2618
	public bool EDNKECNMIBK;

	// Token: 0x04000A3B RID: 2619
	public int JFPJBDKKIOC;

	// Token: 0x04000A3C RID: 2620
	public string[] CLKPCHGNCPQ = new string[6];

	// Token: 0x04000A3D RID: 2621
	public string[] GMQKGNOMIGD = new string[6];

	// Token: 0x04000A3E RID: 2622
	private bool QHLPMOPOBNJ;

	// Token: 0x04000A3F RID: 2623
	public int EDKQQKOCHPK = 1;

	// Token: 0x04000A40 RID: 2624
	public int OOKMKQFENFK;

	// Token: 0x04000A41 RID: 2625
	public DBQLOHBBJMG.NPJODDPEEQF[] ECJEIQPGMPO;

	// Token: 0x04000A42 RID: 2626
	public DBQLOHBBJMG.NPJODDPEEQF[] LGOJEHFKLCL;

	// Token: 0x04000A43 RID: 2627
	private bool DMIEIKIPDII;

	// Token: 0x04000A44 RID: 2628
	private bool BFPKBMKGDEJ;

	// Token: 0x04000A45 RID: 2629
	public DBQLOHBBJMG.FDJOEICCEOG[] CBDCGKPHPJO;

	// Token: 0x04000A46 RID: 2630
	public DBQLOHBBJMG.FDJOEICCEOG[] JELLELLGLLB;

	// Token: 0x04000A47 RID: 2631
	private GameObject[] IFPHQQEQBKJ = new GameObject[50];

	// Token: 0x04000A48 RID: 2632
	private int[] OQOKJNGKEOD = new int[6];

	// Token: 0x04000A49 RID: 2633
	public bool NDEDPKOEDIB;

	// Token: 0x04000A4A RID: 2634
	private int LOGEQNIDFBJ;

	// Token: 0x04000A4B RID: 2635
	private int BNNGMBEHDDC;

	// Token: 0x04000A4C RID: 2636
	public bool QQQBDBNCMCP;

	// Token: 0x04000A4D RID: 2637
	public Camera KKJQCCLEGEE;

	// Token: 0x04000A4E RID: 2638
	public Camera OJQMEBDJDHB;

	// Token: 0x04000A4F RID: 2639
	public Color[] GKIJGKFELNO;

	// Token: 0x04000A50 RID: 2640
	public bool CHGQGQOEEQC = true;

	// Token: 0x04000A51 RID: 2641
	public Material[] KOQMQKJJFBL;

	// Token: 0x04000A52 RID: 2642
	public Color KCPOONBOQPN;

	// Token: 0x04000A53 RID: 2643
	public Light[] GOICFIMCOLK;

	// Token: 0x04000A54 RID: 2644
	[CompilerGenerated]
	private static Dictionary<string, int> KOFFPBGDGFD;

	// Token: 0x04000A55 RID: 2645
	[CompilerGenerated]
	private static Dictionary<string, int> OJHKGFECNFC;

	// Token: 0x04000A56 RID: 2646
	[CompilerGenerated]
	private static Dictionary<string, int> MBOQBEENGIB;

	// Token: 0x04000A57 RID: 2647
	[CompilerGenerated]
	private static Dictionary<string, int> FLJNQGJEOEF;

	// Token: 0x04000A58 RID: 2648
	[CompilerGenerated]
	private static Dictionary<string, int> DJPFNKNLFIK;

	// Token: 0x04000A59 RID: 2649
	[CompilerGenerated]
	private static Dictionary<string, int> JLMQPDJICNI;

	// Token: 0x04000A5A RID: 2650
	[CompilerGenerated]
	private static Dictionary<string, int> PHBKJLKHNLK;

	// Token: 0x04000A5B RID: 2651
	[CompilerGenerated]
	private static Dictionary<string, int> HIMNENGLJPJ;

	// Token: 0x04000A5C RID: 2652
	[CompilerGenerated]
	private static Dictionary<string, int> FKHELOFBCFB;

	// Token: 0x04000A5D RID: 2653
	[CompilerGenerated]
	private static Dictionary<string, int> CFLPBCQFFLP;

	// Token: 0x04000A5E RID: 2654
	[CompilerGenerated]
	private static Dictionary<string, int> EQFOKFJLPOH;

	// Token: 0x04000A5F RID: 2655
	[CompilerGenerated]
	private static Dictionary<string, int> MHKHIFLEKFG;

	// Token: 0x04000A60 RID: 2656
	[CompilerGenerated]
	private static Dictionary<string, int> JDLCHNPJLDO;

	// Token: 0x04000A61 RID: 2657
	[CompilerGenerated]
	private static Dictionary<string, int> ICLCPPIKNHB;

	// Token: 0x04000A62 RID: 2658
	[CompilerGenerated]
	private static Dictionary<string, int> BPIKHEHHMEI;

	// Token: 0x04000A63 RID: 2659
	[CompilerGenerated]
	private static Dictionary<string, int> FNFLDKFEKQH;

	// Token: 0x04000A64 RID: 2660
	[CompilerGenerated]
	private static Dictionary<string, int> OGKIDGHBDQQ;

	// Token: 0x04000A65 RID: 2661
	[CompilerGenerated]
	private static Dictionary<string, int> FFQQHDPFGNO;

	// Token: 0x04000A66 RID: 2662
	[CompilerGenerated]
	private static Dictionary<string, int> KKELGNLMLDN;

	// Token: 0x04000A67 RID: 2663
	[CompilerGenerated]
	private static Dictionary<string, int> JPIFMDDHGMJ;

	// Token: 0x04000A68 RID: 2664
	[CompilerGenerated]
	private static Dictionary<string, int> DHCPBHHBQLO;

	// Token: 0x04000A69 RID: 2665
	[CompilerGenerated]
	private static Dictionary<string, int> DKCBCJLFFCK;

	// Token: 0x04000A6A RID: 2666
	[CompilerGenerated]
	private static Dictionary<string, int> GHEGNNQHKBL;

	// Token: 0x02000177 RID: 375
	private class EFQENJNJIEF
	{
		// Token: 0x04000A6B RID: 2667
		public int MLKGPDPKKCE;

		// Token: 0x04000A6C RID: 2668
		public int QEPKKJKQMPP;

		// Token: 0x04000A6D RID: 2669
		public string FPQBICGEHMJ = string.Empty;

		// Token: 0x04000A6E RID: 2670
		public string NNHFLHEQMOI = string.Empty;
	}

	// Token: 0x02000178 RID: 376
	private class MDECBDPGEBO
	{
		// Token: 0x04000A6F RID: 2671
		public int MLKGPDPKKCE;

		// Token: 0x04000A70 RID: 2672
		public int QEPKKJKQMPP;
	}

	// Token: 0x02000179 RID: 377
	public class QQKKGEJLMLK
	{
		// Token: 0x04000A71 RID: 2673
		public string OPDIDQJIJON = string.Empty;

		// Token: 0x04000A72 RID: 2674
		public bool BKNFHNFFCHE;

		// Token: 0x04000A73 RID: 2675
		public int EOMPMQNGIBD;

		// Token: 0x04000A74 RID: 2676
		public string OQDOCCGPJDQ = string.Empty;

		// Token: 0x04000A75 RID: 2677
		public int DCFKMOILHEC = 1;

		// Token: 0x04000A76 RID: 2678
		public int QKBGGCKIOLG = 1;

		// Token: 0x04000A77 RID: 2679
		public string PLCBFLQBCQN;

		// Token: 0x04000A78 RID: 2680
		public int DBPKNCDGGEP;

		// Token: 0x04000A79 RID: 2681
		public string KMNQBFKKNMB;
	}

	// Token: 0x0200017A RID: 378
	private class PJELBGQDEFC
	{
		// Token: 0x04000A7A RID: 2682
		public DBQLOHBBJMG.EFQENJNJIEF QDLONHBDODI;

		// Token: 0x04000A7B RID: 2683
		public string CGHQEHCBQHB = string.Empty;

		// Token: 0x04000A7C RID: 2684
		public string KQENJEENGNH = string.Empty;

		// Token: 0x04000A7D RID: 2685
		public bool KMNMKEIOGFI;

		// Token: 0x04000A7E RID: 2686
		public bool QHLIEEGQIDQ;

		// Token: 0x04000A7F RID: 2687
		public DBQLOHBBJMG.MDECBDPGEBO[] QFDKFDHBPBF;

		// Token: 0x04000A80 RID: 2688
		public string KDMEFLFNIOO = string.Empty;

		// Token: 0x04000A81 RID: 2689
		public string POLLCNHCQQC = string.Empty;

		// Token: 0x04000A82 RID: 2690
		public string BGDGEKEKOIE = string.Empty;

		// Token: 0x04000A83 RID: 2691
		public string BCHJNMCJPHG = string.Empty;

		// Token: 0x04000A84 RID: 2692
		public bool FHFQGFHIBOM;

		// Token: 0x04000A85 RID: 2693
		public bool MMJOCGHBFOM;

		// Token: 0x04000A86 RID: 2694
		public bool NFPKBFPEPLJ;

		// Token: 0x04000A87 RID: 2695
		public bool IJBDEJBECBH;

		// Token: 0x04000A88 RID: 2696
		public bool DEPGENPNMCM;

		// Token: 0x04000A89 RID: 2697
		public bool FHFOMOLCIPQ;

		// Token: 0x04000A8A RID: 2698
		public bool GMJJOGFDQBL;

		// Token: 0x04000A8B RID: 2699
		public bool IEJDINIGJNF;

		// Token: 0x04000A8C RID: 2700
		public bool DPIIMQEDCEE;

		// Token: 0x04000A8D RID: 2701
		public bool EQOKIDDKCGO;

		// Token: 0x04000A8E RID: 2702
		public bool DMLODDCIEQN;

		// Token: 0x04000A8F RID: 2703
		public bool NJNGIIDHEGG;
	}

	// Token: 0x0200017B RID: 379
	private class QPIHHQDNQGD
	{
		// Token: 0x04000A90 RID: 2704
		public string KDMEFLFNIOO = string.Empty;

		// Token: 0x04000A91 RID: 2705
		public string POLLCNHCQQC = string.Empty;

		// Token: 0x04000A92 RID: 2706
		public string BGDGEKEKOIE = string.Empty;
	}

	// Token: 0x0200017C RID: 380
	private class GQNLOLLCIEB
	{
		// Token: 0x04000A93 RID: 2707
		public int DBPKNCDGGEP;

		// Token: 0x04000A94 RID: 2708
		public string FPQBICGEHMJ = string.Empty;
	}

	// Token: 0x0200017D RID: 381
	private class IEQGPCMELME
	{
		// Token: 0x04000A95 RID: 2709
		public int EKOMDNFNLCM;

		// Token: 0x04000A96 RID: 2710
		public int DDGHMKCGIDM = 100;
	}

	// Token: 0x0200017E RID: 382
	public class NPJODDPEEQF
	{
		// Token: 0x04000A97 RID: 2711
		public OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG;

		// Token: 0x04000A98 RID: 2712
		public DBQLOHBBJMG.QQKKGEJLMLK JMDLLJPEFKM;
	}

	// Token: 0x0200017F RID: 383
	public class FDJOEICCEOG
	{
		// Token: 0x04000A99 RID: 2713
		public int EOMPMQNGIBD;

		// Token: 0x04000A9A RID: 2714
		public int BEQHNFFEHMQ;

		// Token: 0x04000A9B RID: 2715
		public string KMNQBFKKNMB;

		// Token: 0x04000A9C RID: 2716
		public string OQDOCCGPJDQ = string.Empty;

		// Token: 0x04000A9D RID: 2717
		public string PLCBFLQBCQN = string.Empty;

		// Token: 0x04000A9E RID: 2718
		public int QKNEIJQHGCB;

		// Token: 0x04000A9F RID: 2719
		public bool BKNFHNFFCHE;

		// Token: 0x04000AA0 RID: 2720
		public string FDGMQFNGKKL = string.Empty;

		// Token: 0x04000AA1 RID: 2721
		public int BCJGCNQJEGI;

		// Token: 0x04000AA2 RID: 2722
		public int DCFKMOILHEC;
	}
}
