# BinApi

This is a brief demonstration for an interview code challenge of a business API.  It showcases making a piece of software to handle a specific scenario (See: Code challenge scenario).

### If I were to continue:
- Collaborate and clarify with team on requirements.
- Fully implement every aspect of the API's interactions needed.
- Implement logging
- Implement error handling
- I'd want many more test cases that handled **Bad Data** situations as well as fully fleshed out happy path cases.
- I'd add XML documentation to every method and property.
- I'd want to get paid :)

## Built using:
- VS2022
- .NET 7
- ASP.NET
- MSTestV2
- GitHub Actions for continuous integration build and test on PR or Merge against master

## Code challenge scenario:
- The premise is we're building a simple inventory management system. Your team is tasked
with building the inventory Bin maintenance portion that will store what inventory is contained
within each bin.
- The actual Items in the catalog will come from another internal team.
- The actual Bins contained in the catalog will come from a 3rd party system called Smart Rack.
- The inventory catalog knows nothing about the bin catalog and the bin catalog knows nothing
about the inventory catalog.
- Some details may have been assumed and/or left out however it is safe to make any
assumptions that you feel are appropriate/necessary if it's able to be explained why that decision
was made and it's changeable in-case the business unit comes back and clarifies differently than
was assumed.
- The focus of the architecture is maintainability and adaptability as things can/will change.
- An Event Storming session has been done, aggregates have been predefined and some basic
class responsibility collaborator cards have been defined. An event storming legend has
provided in case you are not familiar or need a refresher.
- Item aggregate is more of a catalog of Items simply storing static information about each Item.
It does not store quantity but will need to be able to get the total quantity from the bin aggregate
when necessary.
- The actual catalog of Bins to utilize comes from a 3rd party Smart Rack system API.
- The exact signature of the API of the 3rd party Smart Rack system is not yet known. For now,
the calls to get the list of newly added bins can be mocked according to your needs. It will need
to easily be wired up to the appropriate API in the future once the signature of the API is known.
- The actual catalog of Items to utilize comes from another team’s system. For now, the calls to
get the list of newly added items can be mocked according to your needs. It will need to easily be
wired up to the appropriate API in the future once the signature of the API is known.
- We persist data in a JSON file for testing purposes and in an RDBMS for production purposes.
For the sake of time and example the persisting to an RDBMS can throw a
NotImplementedException when invoked.
- UI will be developed later, and the exact technology is to be determined but it can get/accept its
information via JSON encoded HTTP calls.
