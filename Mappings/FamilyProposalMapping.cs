using c_.Dto;
using c_.INGENZIModels;
using AutoMapper;
namespace c_.Mappings
{
    public class FamilyProposalMapping : Profile
    {
            public FamilyProposalMapping()
            {
                CreateMap<ProposalRegister, FamilyProductDto>();
                CreateMap<FamilyProductDto, ProposalRegister>();
            }
        
    }
}
