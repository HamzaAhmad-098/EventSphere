using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class MemberBL
    {
        MemberDL memberDL = new MemberDL();
        public List<Member> GetMembers()
        {
            return memberDL.GetMembers();
        }
        public void AddMember(Member member)
        {
            if (string.IsNullOrWhiteSpace(member.Name))
                throw new Exception("Member name cannot be empty.");
            memberDL.AddMember(member);
        }
        public void UpdateMember(Member member)
        {
            if (member.MemberId <= 0)
                throw new Exception("Invalid member selection.");
            if (string.IsNullOrWhiteSpace(member.Name))
                throw new Exception("Member name cannot be empty.");
            memberDL.UpdateMember(member);
        }
        public void DeleteMember(int memberId)
        {
            if (memberId <= 0)
                throw new Exception("Invalid member selection.");
            memberDL.DeleteMember(memberId);
        }
        public List<Member> GetMembersByCommittee(int committeeId)
        {
            return memberDL.GetMembersByCommittee(committeeId);
        }
    }
}
