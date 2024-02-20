using c_.Dto;
using Microsoft.AspNetCore.Mvc;
using c_.INGENZIModels;

namespace c_.service
{
    public interface IProductProposalService
    {
     Task<string> CreateFamilyProposal(FamilyProductDto proposalInput, string product);   
      // add another proposal for a different product
     Task<string> CreateEducationProposal(ProposalRegister proposal, string product);  
    }
}
