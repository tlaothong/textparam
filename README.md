# Text Parameter

## Objectives

* Implement a module which can
> * Match Y/N
> * Extract Vars
* Constraints: NO REGEX

## Example
**Urls**  
[1] https://mana.com/linkto/{link-id}  
[2] http://google.com/?s={keyword}  
[3] https://mana.com/app/{app-id}/services/{service-id}  
[4] https://mana.com/nana/{app/-id}/services/{service-id}  

**Input.1** https://mana.com/linkto/A2348  
> Match [1]
> https://mana.com/linkto/{link-id}  

|Key|Value|
|--|--|
|{link-id}|A2348|

**Input.2** https://mana.com/app/di394/services/878  
> Match [3]
> https://mana.com/app/{app-id}/services/{service-id}  

|Key|Value|
|--|--|
|{app-id}|di394|
|{service-id}|878|

**Input.3** https://mana.com/nana/di394/services/services/878  
> Match [4]
> https://mana.com/nana/{app/-id}/services/{service-id}  

|Key|Value|
|--|--|
|{app/-id}|di394|
|{service-id}|services/878|
